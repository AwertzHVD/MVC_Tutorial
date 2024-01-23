# Create MVC Web App

In Visual Studio create "ASP.NET Core Web App (Model View Controller)" and save to a workspace.
It might help to filter by project type Web.

![Image](https://github.com/AwertzHVD/BS-Linz2_Archery_Team2/assets/104345472/2f5c1edf-dfb8-4c9d-8528-617ff8b75166)


![Image](https://github.com/AwertzHVD/BS-Linz2_Archery_Team2/assets/104345472/61f13a7f-c36d-4aca-b734-908fba712f86)


![Image](https://github.com/AwertzHVD/BS-Linz2_Archery_Team2/assets/104345472/e4fc69f8-6707-4dc5-b5d1-36ac6fed9ee3)

Start https
![Image](https://github.com/AwertzHVD/BS-Linz2_Archery_Team2/assets/104345472/778b9d70-94cd-4a5f-bdf3-4b1ce12225d7)


![Image](https://github.com/AwertzHVD/BS-Linz2_Archery_Team2/assets/104345472/78ea6562-7590-462c-866c-23c3ef751be3)

https://localhost:7241/ will open automatically
![Image](https://github.com/AwertzHVD/BS-Linz2_Archery_Team2/assets/104345472/5d539ea2-b407-48bb-bd29-536177f5d026)

## Set Breakpoint
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/7c0fa8f0-ef7a-4923-ac06-134cf0924e7c)

Controller has a HomeController, so Views has to have a directory Home

## Add new Controller "School"
Stop project first, then add Controller
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/f9bcd3a2-f398-4129-969b-5f99be9bcd74)

Add Empty Controller
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/169f5c99-69ac-4ae3-ae4b-8c77c623b908)

### Controller naming
SchoolController.cs => Controller has been added to directory Controllers.
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/409ecaf2-9f76-41a9-8368-2d6e53349ce1)

Then change Index() to GetSchool()
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/69233649-86e5-4927-9891-04985e99bd27)

## Create "School" Directory
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/d89b5804-3444-4995-9226-7bc0fc9628ed)


## Add new View "School"
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/2bb599e4-babe-4150-ad37-e76cd936d6aa)

Add empty View
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/1d2a19f4-3814-4a96-9c61-1fcc94bec108)
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/e49642aa-a85f-43f2-a06a-43da0f2a1965)

## Add navigation item to navigation bar
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/25a7b66b-b988-4fec-a8ea-2a7231859eb3)

### Edit GetSchool.cshtml
Add message like "Hello World !"

### Run Project
Notice how a new navigation item has been added. After clicking on navigation item, "Hello World !" will be displayed.
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/9a24fd60-1715-4253-ac5f-7b072d9f9018)

## Controll in Dev Tools
After clicking on GetSchool
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/64b1029c-1e8a-4744-99f1-ff342d88856d)

## Create new Model "School"
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/215a49b9-df80-4fc5-9594-dd39e281f5cd)
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/1d7de305-01f9-42db-b71e-163f4bb7cccb)

### Define Model
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/21e094aa-de0d-437c-bdd1-ac6036b0bedd)

## Edit SchoolController.cs
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/b18e1ea8-9d46-4de4-bb56-7a89b5535224)

### Edit GetSchool.cshtml
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/e180b60d-ec58-486a-91b1-55951cea0642)

### Run Project
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/4a195dc4-9a5a-4755-83b3-206b5ee07a9e)

## Edit SchoolController.cs
View returns List<SchoolModel> instead of single SchoolModel
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/dc4087e6-4e22-4187-b76b-f51e02db2ebb)

### Edit GetSchool.cshtml
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/92543431-f871-4e8d-b5b5-53547ac1e4f0)

### Run Project
List will show content of List<SchoolModel>
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/83465cdc-d295-49aa-8b04-99b14fe5baa2)

## Add Form
Edit GetSchool.cshtml
Create Submit Button and link Id of School
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/0f39231a-d179-4812-b7ad-ea78406e48c6)


### Edit SchoolController.cs
create method EditSchool(int Id)
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/b6cb1637-b5de-4ee0-8469-0ee8f4557e12)

### Run Project
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/b456efbb-d29c-48cb-8d41-dc263a16ea82)

## Add View "EditSchool" in directory School
### Edit SchoolController.cs
Add Where Link
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/a10d18ce-9c68-4d40-92c3-2fb0d8f5a72e)

### Edit EditSchool.cshmlt
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/93fa87f3-3683-4626-8041-6c4a6b791a50)

### Run Project
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/7455d526-8f26-413d-92da-7c0b91b3585d)

## Edit School name
### Edit EditSchool.cshtml
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/c250107e-119c-451c-93dc-d5d399b6079f)

### Edit SchoolController.cs
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/c75af39a-4472-4167-808c-c2285a36e59b)

### Set Breakpoint
![image](https://github.com/AwertzHVD/MVC_Tutorial/assets/104345472/61e57cc4-aa86-40f5-a532-1c17c641be17)

# Setup Database Connection
