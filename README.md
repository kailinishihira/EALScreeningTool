## Hawaii Environmental Action Level Screening Tool

### Kaili Nishihira

#### _This is a web app to screen analytical data from environmental samples against the State of Hawaii's established screening criteria, which are known as the Environmental Action Levels, 11.05.17_


## Description

_The use of this web app is for Environmental Consultants who conduct site investigations on properties throughout the State of Hawaii. Environmental Action Levels (EALs) are concentrations of contaminants in soil, soil gas, and groundwater that are used in decision making throughout the site investigation process._

_The user may create an account to access the web app. The user may create a new project and assign the Site Scenario's three criteria which are: land Use, Groundwater Utility, and Distance to Nearest Surface Water Body. The user may enter the project's sample media types:  Soil, Groundwater, Soil Vapor and Indoor Air. The user may enter each sample's contaminate results and compare it to the state established EAL._

_For more information on EALs, visit the  [State of Hawaii, Dept. of Health](http://eha-web.doh.hawaii.gov/eha-cma/Leaders/HEER/environmental-hazard-evaluation-and-environmental-action-levels)._

|| Behavior  | Example Input  | Example Output  |
|---|---|---|---|
|| The user may create an account <br> Click `Register a new account` | Email: steve@gmail.com <br> Password: xxxxxxxx  | After successfully registering a new account, the user is redirected to the login page |
|| The user may log in to their existing account <br> Click `Login to your account` | Email: steve@gmail.com <br> Password: xxxxxxxx | After successfully logging into their account, the user is redirected to the home page |
|| The user may log out of their account | Click `Log Out` on the navigation bar | The user is redirected to the Login view |
|| The user may create a new project and will be saved in the database <br> Click `Start new project` | Project Name/Type: ABC Company, Phase II <br> Client Name: XYZ Company <br> Site Name: Momo's Grocery Store <br> Site Address: 123 Coconut Lane, Honolulu, HI 96819 <br> Tax Map Key (TMK) #: (1) 2-3-456-789-0000 <br> Land Use: Unrestricted <br> Groundwater Utility: Drinking Water Resource <br> Distance to Nearest Surface Water Body: < 150 m <br> Enter by: Steve Smith <br> Click `Submit` | The user is redirected to the Project Details view where the project details are displayed |
|| The user may edit the Project's details <br> Click `Edit` on the Project's Details view | Project Name: ABC Company, Phase III <br> Click `Update` | The user is redirected to the Project Details view where the updated project details are displayed |
|| The user may delete the Project | Click `Delete Project` on the Project Details view <br> The user is directed to a Delete Confirmation view <br> Click `Delete Project` | The Project is deleted and user is redirected to the Home view |
|| The user may add Sample Media Types to the project | Click `Add Sample Media Types` on the Project Details view <br> Select from options: Soil, Groundwater, Soil Vapor, Indoor Air <br> Click `Add` | The Project Details page is updated with a list of Sample Media Types |
|| The user may add a Sample to the project <br> Click `Soil` (the corresponding Sample Media Type) on the Project Details view <br><br> Note: If Sample Media Type is Soil or Soil Vapor, Sample Depth results are needed. If Sample Media Type is Groundwater, Depth to Groundwater results are needed. | On the Sample Media Type Details view: <br> Project Sample ID#: SS1 <br> Collection Date and Time: 07/03/2017 2:00PM <br> Coordinates (optional): x,y <br> Sample Depth: 10 (feet) <br> Click `Add Sample to Project` | The user is redirected to the Sample Details page with the sample details are listed |
|| The user may add the Sample's actual results for each contaminant's concentration | On the Sample Details view, click on drop down menu and select `Zinc` (contaminant name) <br> Actual Results (mg/kg): 10.1 <br> Click `Submit`| The sample results will appear on the Sample Details view |
|| The user may add additional Sample results |  On the Sample Details view, click on drop down menu and select `Nickel` (contaminant name) <br> Actual Results (mg/kg): 20.2 <br> Click `Submit` | The sample results will appear on the Sample Details view, along with the other Sample results |
|| The user may add additional Soil Samples to the project <br> On the Sample Details view, click `Add Additional Soil Samples` | On the Sample Media Type Details view: <br> Project Sample ID#: SS2 <br> Collection Date and Time: 07/03/2017 2:00PM <br> Coordinates (optional): x,y <br> Sample Depth: 10.5 (feet) <br> Click `Add Sample to Project` | The user is redirected to the Sample Details page with the sample details are listed |
|| The user may update the Sample's actual results <br> Click `Edit` on the Sample Details view | Project Sample ID#: SS1 <br> Contaminant: Nickel <br> Actual Results (mg/kg): 22.5 <br> Click `Update` | The sample results will appear on the Sample Details view, along with the other Sample results |  
|| The user may delete a Sample's results | Click `Delete Sample Results` next to selected Sample on the Sample Details view <br> The user is directed to a Delete Confirmation view <br> Click `Delete Sample Result` | The Sample Result is deleted |
|| The user may filter Sample results to display all Samples equal to or greater than the EALs | Click `Contaminant Exceedances` on the Project Details view |  A list of Samples with Contaminant Exceedances will be displayed |




## Setup/Installation Requirements

* _Download and install [.NET Core 1.1 SDK](https://www.microsoft.com/net/download/core)_
* _Download and install [Mono](http://www.mono-project.com/download/)_
* _Download and install [MAMP](https://www.mamp.info/en/)_
* _Download and install [Visual Studio 2017](https://www.visualstudio.com/)_
* _Clone repository_

### Setup/Installation for Database
* In your terminal, navigate from the Solution folder to the project folder, EALScreeningTool
* Enter `dotnet restore` from the command line
* Enter `dotnet ef database udpate` from the command line

##### Import data from the Cloned Repository
* _Click 'Open start page' in MAMP_
* _Under 'Tools', select 'phpMyAdmin'_
* _Click 'Import' tab_
* _Choose database file (from cloned repository folder)_
* _Click 'Go'_

## Technologies Used
* _C#_
* _.NET_
* _MVC_
* _Entity Framework_
* _[Bootstrap](http://getbootstrap.com/getting-started/)_
* _[MySQL](https://www.mysql.com/)_

### License

Copyright (c) 2017 **_Kaili Nishihira_**

*Licensed under the [MIT License](https://opensource.org/licenses/MIT)*


﻿
