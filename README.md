# ABC Booking application system 
>> **Booking application system created with WPF SQL and C# using Entity framework core.**

The ABC academy needs software for managing the bookings of courses made by the students. The academy offers different courses throughout the year.

**The End user for this application will be the academy front desk executive**

_User will perform the booking related functions based on details provided by the students at the front desk_

 - A student who wants to book a course needs to register on the system first and then be able to select a course on a day.
 - A student can check their booking via the system. Students are allowed to change/cancel a booking.
 - A student can book as many classes as they want as long as there is no date conflict.
 - After each group exercise class, students are able to write a review of the class they have attended and provide a numerical rating of the class ranging from 1 to 5 (1: Very dissatisfied, 2: Dissatisfied, 3: Ok, 4: Satisfied, 5: Very Satisfied). The rating information will be recorded in the system.
 - After four weeks (four weekends), the software system must print:
	- a report containing the number of students per group exercise class on each day, along with the average rating;
    - a report containing the group exercise which has generated the highest income, counting all the same exercise classes together.


**Project definition of 'Done'**

- [x] Acceptance criteria met
- [x] Tests are written for all business project classes and  are passing
- [x] Peer reviewed
- [x] Documentation updated

### Sprints :rocket:

_Sprint_ **1**

>>The aim of this sprint is to create a main graphical user interface _(GUI)_ for the user to interact with the **Student table** so they can insert and view records.

###### Student table will look like following table after inserting a value


StudentID	|First Name	|Last Name	|Email address
------------|-----------|-----------|-------------
1(auto)		|John		|Smith		|jsmith@gmail.com

*List of tasks completed in this sprint backlog are:*
- [x] Create text fields so the user can insert student details via the registration form.
- [x] Check validation for student email address format
- [x] Prevent the system from registering with the same email address more than once
- [x] Create ```view students``` button to check student records.
- [x] Create ```Create booking``` button to open a new window that enables to perform booking-related operations.
- [x] A button to close the application so the system is shutdown.

**Sprint retrospective:**

_What went well_
- Creating the objects(C# classes) and creating database models.
- Creating business classes to write the logic of the application.
- Writing tests and running them.
- Creating WPF windows to make the user interact with the data.

_Improvement_
- Write raw Sql codes inside the business layer and make the front end to access them via public methods.
- Write more validations so that the user cannot input numbers or characters in the text fields.
- Make the GUI design more user friendly.


![Start of sprint #1](https://github.com/BarathNallusamy/BookingApplicationWPF/blob/75dae287f21a3d713411a48be07b320560814f62/Images/sprint%20one%20point%201.jpg)
![End of sprint #1](https://github.com/BarathNallusamy/BookingApplicationWPF/blob/75dae287f21a3d713411a48be07b320560814f62/Images/sprint%20one%20point%202.jpg)

-----------------------------------------------------------------------------------------------------------------------------------------------------------------

_Sprint_ **2**

>>The aim of this sprint is to create a booking window so the user can view existing bookings from the **Booking Table** and also create new bookings. Also view the **Course table** so that the user can select the course ID correctly when making the booking.

###### Booking table will contain data from student and courses table based on their relationship 


BookingID	|Full Name	|Course Name|Booking Date		|Booking Status
------------|-----------|-----------|-------------------|--------------
1(auto)		|John		|Smith		|01/01/2021			|Active

*List of tasks completed in this sprint backlog are:*
- [x] Create a courses table and insert available courses and their prices.
- [x] Show the courses table in the booking window so the user can see all the courses that are offered in the academy.
- [x] Load two combo boxes with courses and student ID data.
- [x] Create a ```Calander item``` so the user can select a date 
- [x] A button to confirm the booking based on selected data.
- [x] A button to close the booking window
- [x] Populate a booking data table so the user can see all the bookings made till date.

**Sprint retrospective:**

_What went well_
- Creating new window and laying out the button and list boxes.
- Loading the database values inside the combo boxes
- Inserting a calender item and getting the selected value from it.
- Creating new booking and propulating the table.

_Improvement_
- Write raw Sql codes inside the business layer and make the front end to access them via public methods.
- Combo box to show student name and course name along with their ID's respectively for user ease of use.



![Start of sprint #1](https://github.com/BarathNallusamy/BookingApplicationWPF/blob/75dae287f21a3d713411a48be07b320560814f62/Images/sprint%20two%20point%201.jpg)
![End of sprint #1](https://github.com/BarathNallusamy/BookingApplicationWPF/blob/75dae287f21a3d713411a48be07b320560814f62/Images/sprint%20two%20point%202.jpg)

-----------------------------------------------------------------------------------------------------------------------------------------------------------------

_Sprint_ **3**

>>The aim of this sprint is to move core functions out of the front end layer to the back end business layer so the database is secured.
>>

*List of tasks completed in this sprint backlog are:*
- Move the raw SQL methods inside the business layer
- Use public methods in WPF layer to access the data values.

**Sprint retrospective:**

_What went well_
- Moving the methods to business layer and writing public methods.
- Accessing the data via methods.

_Improvement_
- Write more robust query using Linq syntax or method syntax 

![Start of sprint #1](https://github.com/BarathNallusamy/BookingApplicationWPF/blob/75dae287f21a3d713411a48be07b320560814f62/Images/sprint%20three%20point%201.jpg)
![End of sprint #1](https://github.com/BarathNallusamy/BookingApplicationWPF/blob/75dae287f21a3d713411a48be07b320560814f62/Images/sprint%20three%20point%202.jpg)

## Overall project retrospective 
In this project I have learned how to modularise the codes to write simple applications. I was able to seperate projects for backend database and front end WPF then use Entity framework to work in the middle as a communicator. This enabled me to use the OOP encapsulation to write public functions in C# classes and use them in the front end application, thus making the software more secure and robust. 

This application is still in a basic level and it has a large future scope such as creating user login and enabling various permissions for administrators. Also we can include an option for  students to write review after completing their courses successfully.

***User Guide***
To start the application please run the BookingGUI project as the startup project. 
>>There are no login page therefore the user can start using the buttons provided in the main window



This is the `Main` method
```Csharp
public static void Main(){
	
}
```

##Task lists
- [ ] this is a list item
- [x] this item is marked


