using StudentGroup;

Group group1 = new Group("pb401", 3, new DateTime(2024, 03, 30), new DateTime(2025, 05, 30));
Group group2 = new Group("PB401", 2, new DateTime(2024, 04, 30), new DateTime(2025, 01, 20));

group1.GetDetails();
group2.GetDetails();

Student student1 = new Student("Agasi", "Agarahimov");
Student student2 = new Student("Eli", "Eliyev");
Student student3 = new Student("Veli", "Veliyev");
Student student4 = new Student("Fuad", "Fuadov");

group1.AddStudent(student1);
group1.AddStudent(student2);
group1.AddStudent(student3);
group2.AddStudent(student4);

group1.RemoveStudent(student1);

group1.GetStudents();
group2.GetStudents();

Teacher teacher1 = new Teacher("Ali", "Baliyev");
Teacher teacher2 = new Teacher("Israfil", "Israfilov");

group1.AddTeacher(teacher1);
group1.AddTeacher(teacher2);
group1.GetTeachers();

group1.RemoveTeacher(teacher1);
group1.GetTeachers();

Topic topic1 = new Topic("Math");
Topic topic2 = new Topic("Chemistry");

group1.AddTopic(topic1);
group1.AddTopic(topic2);
group1.GetTopics();

group1.RemoveTopic(topic1);
group1.GetTopics();
