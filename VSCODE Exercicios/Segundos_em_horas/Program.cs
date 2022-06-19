int horas, mins, segs, segundos = int.Parse(Console.ReadLine());
horas = segundos / 3600;
mins = (segundos % 3600)/ 60;
segs = (segundos % 3600) % 60;
Console.WriteLine(horas+":"+mins+":"+segs);
