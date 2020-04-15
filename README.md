# GoTCPHolePuncher
A proof of concept for TCP hole punching in C# .NET. But the concept is the same and can be used in any programming language. 

This application works based on basic Hole punching concepts as below.
<ul>
    <li>Peer A sends a SYN to Peer B</li>
    <li>Peer B sends a SYN to Peer A</li>
    <li>When NAT-a receives the outgoing SYN from Peer A, it creates a mapping in its state machine.</li>
    <li>When NAT-b receives the outgoing SYN from Peer B, it creates a mapping in its state machine.</li>
    <li>Both SYN cross somewhere along the network path, then:</li>
    <li>SYN from Peer A reaches NAT-b, SYN from Peer B reaches NAT-a</li>
    <li>Depending on the timing of these events (where in the network the SYN cross),
at least one of the NAT will let the incoming SYN through, and map it to the internal destination peer</li>
    <li>Upon receipt of the SYN, the peer sends a SYN+ACK back and the connection is established.</li>
</ul>

  1. Server and Client are built in the same application. We can open any number of clients from the same application itself for testing purposes also.<br>
<img src="https://github.com/krrrishh/GoTCPHolePuncher/blob/master/Screenshots/1.%20Client%20Server%20Main%20Form.png"><br><br>
  2. Server is to be started in a Open Port Server. Or you can port forward a particular port. Select the port number and press "Start Server"<br>
 <img src="https://github.com/krrrishh/GoTCPHolePuncher/blob/master/Screenshots/2.%20Server%20Form.png"><br><br>
  3. Open 2 clients behind NAT firewall in different locations. Enter the server address and port correctly. Give different name for the Clients so that it registers correctly. Once registered press connect. If connection succeeds then the client tab wil open.<br>
 <img src="https://github.com/krrrishh/GoTCPHolePuncher/blob/master/Screenshots/3.%20Clients%20A%20and%20B.png"><br><br>
  4. Once the clients are connected the server will have the ip endpoint of both the clients.<br>
 <img src="https://github.com/krrrishh/GoTCPHolePuncher/blob/master/Screenshots/4.%20Registered%20Clients%20in%20Server.png"><br><br>
  5. Not if more than once client is registered a tab will be created in the client form for each new clients.<br>
 <img src="https://github.com/krrrishh/GoTCPHolePuncher/blob/master/Screenshots/5.%20Client%20Connect%20Option.png"><br><br>
  6. Now if you press the connect button to particular client it will send a command to server to initiate connection between two clients to begin hole punching. Clients receive the endpoints and begins connecting from both sides. If connection succeeds the send text box will be enabled and connect option is disabled.<br>
 <img src="https://github.com/krrrishh/GoTCPHolePuncher/blob/master/Screenshots/6.%20Client%20to%20Client%20Message%20Transfer.png"><br><br>
  7. Now both clients can communicate directly without the help of the server. If the client is closed then server notifies the same to all the clients<br>
 <img src="https://github.com/krrrishh/GoTCPHolePuncher/blob/master/Screenshots/7.%20Message%20sending%20after%20hole%20punching.png"><br><br>
  8. The server can be checked to see what message are transferred to clients.<br>
 <img src="https://github.com/krrrishh/GoTCPHolePuncher/blob/master/Screenshots/8.%20Server%20after%20all%20operations.png"><br><br>
 <br><br>
  This is tested with multiple commercial routers like Netgear, TP-Link, D-Link. In Cyberoam like firewalls it connects 3 out of 5 times. Will upload the test result soon.
