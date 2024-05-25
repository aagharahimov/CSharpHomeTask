using StudentGroup;

Group group1 = new Group("pb401",1, new DateTime(2024, 03, 30), new DateTime(2025, 05, 30));
Group group2 = new Group("PB401", 2, new DateTime(2024, 04, 30 ), new DateTime(2025,01,20));
group1.GetDetails();
group2.GetDetails();


Student student1 = new Student("Agasi", "Agarahimov");
Student student2 = new Student("eli", "eliyev");
Student student3 = new Student("veli", "veliyev");
Student student4 = new Student("fuad", "fuadov");

group1.AddStudent(student1);
group1.AddStudent(student2);
group1.AddStudent(student3);
group2.AddStudent(student4);

group1.RemoveStudent(student1);

group1.GetStudents();
group2.GetStudents();


