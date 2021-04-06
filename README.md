# BookingApplicationWPF
**Booking application system created with WPF SQL and C#**

The ABC academy needs software for managing the bookings of courses made by the students. The academy offers different courses throughout the year. 

A student who wants to book a course needs to register on the system first and then be able to select a course on a day. A student can check their booking via the system. Students are allowed to change a booking, provided there are still spaces available for the newly selected class. A student can book as many classes as they want so long as there is no time conflict.

***Sprint goals shown below***

- EPIC 1:
As a student, I need to login into the system, so I can access my account securely.
  - USER STORY 1.1:
  As a student, I need to register on the system so I can start using the booking application.
  - USER STORY 1.2:
  As a student, I need to add my details into the system to register myself
  
  - A/C 1: 
  Scenario: Student clicks the register button
  * Given I am on the main window
  * When I click the register button
  * Then I should receive a confirmation of registration with an autogenerated Student ID assigned to me by the system.

- EPIC 2:
As a student, once I have registered on the system I should be able to view courses and create a booking.
  - USER STORY 2.1:
  As a student, I need to access the booking manager to view the courses
  - USER STORY 2.2:
  As a student, I need to create a booking using my unique Student ID.
  
  A/C 2: 
  Scenario: Student confirms a booking in the booking window
  * Given I am on the booking window
  * When I click the book button
  * Then I should receive a confirmation of enrollment with an autogenerated Booking ID assigned to me by the system.
