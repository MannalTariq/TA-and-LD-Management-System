**Project Overview**  
This project manages various roles and tasks within an academic setting, including Course Instructors, Lab Instructors, Teacher Assistants (TA), and Lab Demonstrators (LD). It covers functionalities such as user management, profile management, task management, and salary generation.

**Modules:**
1. **User Management**
   - Admin can register and manage user accounts.
   - Role-based access controls for different users (LD, TA, Instructors).
   
2. **Profile Management**
   - Admin can create and update profiles of Course Instructors, Lab Instructors, TAs, and LDs.

3. **Assignment Management**
   - Admin assigns TAs and LDs to specific courses and sections.

4. **Task Management**
   - TAs and LDs can mark tasks as completed.
   - Instructors can add, update, or delete tasks.

5. **Attendance and Hours Tracking**
   - Tracks attendance and working hours of TAs and LDs.

6. **Salary Generation**
   - Calculates salaries for TAs and LDs based on their hours worked.

**Database Design:**  
The system uses a relational schema to store information about users, courses, sections, and tasks.  
Data is normalized up to 3NF for efficiency.

**ERD:**  
![ERD](https://github.com/user-attachments/assets/6f1791aa-ca6c-4b7e-b70f-10646d1902ee)

**EERD:**  
![EERD](https://github.com/user-attachments/assets/b0ba857c-5b2c-4763-8066-274c759abf01)

**User Documentation:**  
- **Admin**: Can manage user profiles, assign roles, and view task details.
- **Instructor**: Can add, update, or delete tasks assigned to TAs and LDs.
- **TAs/LDs**: Can view assigned tasks, mark them as completed, and check their attendance and salary details.


