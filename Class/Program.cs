using Class;

// Öğrenci bilgilerini oluşturur.
Person student1 = new Person();
student1.FirstName = "Ali";
student1.LastName = "Ayhan";
student1.BirthDate = new DateTime(2006, 12, 19);

Person student2 = new Person();
student2.FirstName = "Şeyda";
student2.LastName = "Kara";
student2.BirthDate = new DateTime(2006, 12, 28);


// Öğretmen bilgilerini oluşturur.
Person teacher1 = new Person();
teacher1.FirstName = "Ahmet";
teacher1.LastName = "Sulu";
teacher1.BirthDate = new DateTime(1993, 8, 9);

Person teacher2 = new Person();
teacher2.FirstName = "Nil";
teacher2.LastName = "Ekşi";
teacher2.BirthDate = new DateTime(1991, 1, 7);


// Öğrenci bilgilerini yazdırır.
Console.WriteLine("Students:");
student1.PrintDetails();
Console.WriteLine();
student2.PrintDetails();
Console.WriteLine();


// Öğretmen bilgilerini yazdırır.
Console.WriteLine("Teachers:");
teacher1.PrintDetails();
Console.WriteLine();
teacher2.PrintDetails();
