﻿using ProfileServerCrypto;
using ProfileServerProtocol;
using Iop.Profileserver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProfileServerProtocolTests.Tests
{
  /// <summary>
  /// PS01013 - Application Service Receive Message Notification Response - Bad Role
  /// https://github.com/Internet-of-People/message-protocol/blob/master/tests/PS01.md#ps01013---application-service-receive-message-notification-response---bad-role
  /// </summary>
  public class PS01013 : ProtocolTest
  {
    public const string TestName = "PS01013";
    private static NLog.Logger log = NLog.LogManager.GetLogger("ProfileServerProtocolTests.Tests." + TestName);

    public override string Name { get { return TestName; } }

    /// <summary>List of test's arguments according to the specification.</summary>
    private List<ProtocolTestArgument> argumentDescriptions = new List<ProtocolTestArgument>()
    {
      new ProtocolTestArgument("Server IP", ProtocolTestArgumentType.IpAddress),
      new ProtocolTestArgument("primary Port", ProtocolTestArgumentType.Port),
    };

    public override List<ProtocolTestArgument> ArgumentDescriptions { get { return argumentDescriptions; } }


    /// <summary>
    /// Implementation of the test itself.
    /// </summary>
    /// <returns>true if the test passes, false otherwise.</returns>
    public override async Task<bool> RunAsync()
    {
      IPAddress ServerIp = (IPAddress)ArgumentValues["Server IP"];
      int PrimaryPort = (int)ArgumentValues["primary Port"];
      log.Trace("(ServerIp:'{0}',PrimaryPort:{1})", ServerIp, PrimaryPort);

      bool res = false;
      Passed = false;

      ProtocolClient client = new ProtocolClient();
      try
      {
        MessageBuilder mb = client.MessageBuilder;

        // Step 1
        await client.ConnectAsync(ServerIp, PrimaryPort, false);

        Message requestMessage = mb.CreateApplicationServiceReceiveMessageNotificationRequest(new byte[] { 0 } );
        Message responseMessage = mb.CreateApplicationServiceReceiveMessageNotificationResponse(requestMessage);
        await client.SendMessageAsync(responseMessage);

        // We should be disconnected by now, so sending or receiving should throw.
        byte[] data = Encoding.UTF8.GetBytes("Hello");
        byte[] payload = Crypto.Sha256(data);
        requestMessage = mb.CreatePingRequest(payload);

        bool disconnectedOk = false;
        try
        {
          await client.SendMessageAsync(requestMessage);
          await client.ReceiveMessageAsync();
        }
        catch
        {
          log.Trace("Expected exception occurred.");
          // Step 1 Acceptance
          disconnectedOk = true;
        }

        Passed = disconnectedOk;
        

        res = true;
      }
      catch (Exception e)
      {
        log.Error("Exception occurred: {0}", e.ToString());
      }
      client.Dispose();

      log.Trace("(-):{0}", res);
      return res;
    }
  }
}
