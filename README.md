# Angular 5 & .Net Web API Rental Web Service

![](https://github.com/YoniProbeh/RentalAPI/blob/master/Client/src/img/overview-min.gif?raw=true)

=================================================================================
# Configuration

### 1. Server Setup
In Order To Successfully Establish A Network Connection Between The Client & The Server,
It Is Necessary To First Properly Initialize And And Run The Server - Otherwise No Data Will Be Transferred Through The API To The Client.

=================================================================================

**Initializing & Running The Server Locally**

![](https://github.com/YoniProbeh/RentalAPI/blob/master/Server/Library/img/build-min.gif?raw=true)

As Displayed Above, In Order To Initalize The Server You Must First Open The Solution In Visual Studio
1. Go To The Package Manager Console At The Bottom Of The Screen => Select "Data" As The Default Project
2. In The Solution Explorer, Right Click On The "Data" Project" => Select `Set As Startup Project`
3. Enter `Update-Database` => Click Enter (Verifying That All Seed Methods Were Executed And The Database Is Updated Accordingly
4. In The Solution Explorer, Right Click On The "Server" Project => Select `Setup As Default Project`
5. Now Press `ctrl+F5` To Compile And Run The Application
6. To Test The API's Quality, Navigate In The Browser To `https://localhost:56004/api/Vehicles` To See If Any Values Were Retrieved

=================================================================================

### 2. Client Setup

**1. Install Node Dependencies**

![](https://github.com/YoniProbeh/RentalAPI/blob/master/Client/src/img/install-min.gif?raw=true)

**2. Run The Application**

![](https://github.com/YoniProbeh/RentalAPI/blob/master/Client/src/img/serve-min.gif?raw=true)
