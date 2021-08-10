# Demo_ASP.NET_WEB-APP-MVC

This is a Demo application that I developed for school.


some screenshots.


###
Every user that created an account gets the user role student.
Only the admin account is seeded into the database.

[Register Page]

![image](https://user-images.githubusercontent.com/48015605/128919484-d2019841-7f70-4c1e-b082-f8a5849ccf23.png)

[Login Page]

![image](https://user-images.githubusercontent.com/48015605/128918943-0c69c462-89fc-4157-9c2a-859ff70540f3.png)


###

[Regular User Layout]

![image](https://user-images.githubusercontent.com/48015605/128920095-6269d35e-5cbb-4a57-aaa1-fca47ada5d52.png)

the Admin gets a different layout to indicate that the admin is logged in and gets an extra nav link.

[Admin Layout]

![image](https://user-images.githubusercontent.com/48015605/128920303-bd112225-9d21-493a-a74e-3cd8a09540a6.png)


###

(the search bar also works, it searches by usernames.)

[Student Index Page]

![image](https://user-images.githubusercontent.com/48015605/128920913-47f4cbc1-a22b-4bfd-915c-c76a81b25a97.png)


###
if you try to navigate to a page where you need a specific role to access it and you account doesn't have it. then you were navigated to a access denied page.

this is done by using cookie options


Code:
{
  services.ConfigureApplicationCookie(options => options.AccessDeniedPath = "/User/unauthorizedUser");
}

After 5 sec on the unauthorizedUser page you will be redirected to the index Page.
this is done by using a Meta element.

Code: {
  <META HTTP-EQUIV="Refresh" CONTENT="5;URL=@(Url.Action("Index", "Home"))">
  }
  
[Access Denied Page]
  ![image](https://user-images.githubusercontent.com/48015605/128921024-2da588af-33af-4fad-99ae-979754e4f34d.png)


###

I did also used razor pages to show a List about every user. These pages can only be access by a user that has the Admin Role.

[Code for authorizing razor pages]
  
  ![image](https://user-images.githubusercontent.com/48015605/128927750-bd38411b-1394-4228-92fd-cfe26b6e5e63.png)

I authorize the admin folder where the razor pages where used. the authorization is done by using Policy.

[Code for Authorization Policy]
  
  ![image](https://user-images.githubusercontent.com/48015605/128928279-cc6de5c6-e3c2-4f36-874b-d5d4795e659d.png)

#Warning#
  The Role and Policy based authorization will not work if you did correctly organize the "app.UseAuthozization();" between the "app.UseRouting();" and "app.UseEndpionts"
  like this.
  
  ![image](https://user-images.githubusercontent.com/48015605/128928496-2c66990c-8da7-497e-a84b-264057ec8e4f.png)

  (P.S. if you still have a problem with role or policy based authorization Check you project settings if the "Enable Anonymous Authentication" is Checked)
  
  [Project Setting]
  
  ![image](https://user-images.githubusercontent.com/48015605/128931484-d4f3bac2-a4cf-4e88-bc15-49ca567a9e8a.png)


 [User List Page]
  
 ![image](https://user-images.githubusercontent.com/48015605/128927127-5f387f87-ad0a-4360-a449-489ee78c3129.png)






