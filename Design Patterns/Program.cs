using Design_Patterns;

var db = DbClassic.GetInstance();

db.Add(new User { Name = "João", Age = 20 });
db.Add(new User { Name = "Maria", Age = 30 });
db.Add(new User { Name = "José", Age = 40 });

db.Show();

db.Remove(1);

db.Show();

