﻿using System;

namespace OPP_5_2
{
    public class Pupil
    {
        // оцінки в 12-ти бальній системі
        private string firstName; // ім'я 
        private string lastName; // прізвище
        private int markMath; // оцінка з математики
        private int markNat; // оцінка з природознавства
        private int markChoir; // оцінка зі співів
        private int markDraw; // оцінка з малювання
        private int markSport; // оцінка з фізкультури
        private int nMistW; // кількість помилок з письма
        private int nMistR; // кількість помилок з читання

        // властивості
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int MarkMath
        {
            get { return markMath; }
            set
            {
                if (markMath >= 1 && markMath <= 12)
                {
                    markMath = value;
                }
            }
        }
        public int MarkNat
        {
            get { return markNat; }
            set
            {
                if (markNat >= 1 && markNat <= 12)
                {
                    markNat = value;
                }
            }
        }
        public int MarkChoir
        {
            get { return markChoir; }
            set
            {
                if (markChoir >= 1 && markChoir <= 12)
                {
                    markChoir = value;
                }
            }
        }
        public int MarkDraw
        {
            get { return markDraw; }
            set
            {
                if (markDraw >= 1 && markDraw <= 12)
                {
                    markDraw = value;
                }
            }
        }
        public int MarkSport
        {
            get { return markSport; }
            set
            {
                if (markSport >= 1 && markSport <= 12)
                {
                    markSport = value;
                }
            }
        }
        public int NMistW
        {
            get { return nMistW; }
            set
            {
                if (nMistW >= 0 && nMistW <= 11)
                {
                    nMistW = value;
                }
            }
        }
        public int NMistR
        {
            get { return nMistR; }
            set
            {
                if (nMistR >= 0 && nMistR <= 11)
                {
                    nMistR = value;
                }
            }
        }

        public Pupil() // конструктор
        {
            firstName = "";
            lastName = "";
            markMath = 1;
            markNat = 1;
            markChoir = 1;
            markDraw = 1;
            markSport = 1;
            nMistW = 0;
            nMistR = 0;
        }

        public Pupil(string fName, string lName, int mMath, int mNat, int mChoir, int mDraw, int mSport, int nMistW, int nMistR) // конструктор
        {
            firstName = fName;
            lastName = lName;
            markMath = mMath;
            markNat = mNat;
            markChoir = mChoir;
            markDraw = mDraw;
            markSport = mSport;
            this.nMistW = nMistW;
            this.nMistR = nMistR;
        }

        public virtual void Study()
        {
            Console.WriteLine($"{FirstName} {LastName}: оцінка Study: {(markMath + markNat) / 2}");
        }

        public virtual void Write()
        {
            Console.WriteLine($"{FirstName} {LastName}: оцінка Write: {12 - nMistW}");
        }

        public virtual void Read()
        {
            Console.WriteLine($"{FirstName} {LastName}: оцінка Read: {12 - nMistR}");
        }

        public virtual void Relax()
        {
            Console.WriteLine($"{FirstName} {LastName}: оцінка Relax: {(markChoir + markDraw + markSport) / 3}");
        }
    }

    public class ExcelentPupil : Pupil
    {
        public const string grade = "excelent";

        public ExcelentPupil(string fName, string lName, int mMath, int mNat, int mChoir, int mDraw, int mSport, int nMistW, int nMistR) : base(fName, lName, mMath, mNat, mChoir, mDraw, mSport, nMistW, nMistR) { }// конструктор

        public override void Study()
        {
            if ((MarkMath >= 10) & (MarkNat >= 10))
            {
                Console.WriteLine($"Оцінка StudyEx: {(MarkMath + MarkNat) / 2}");
            }
        }

        public override void Write()
        {
            if (NMistW >= 0 && NMistW <= 2)
            {
                Console.WriteLine($"Оцінка WriteEx: {12 - NMistW}");
            }
        }

        public override void Read()
        {
            if (NMistR >= 0 && NMistR <= 2)
            {
                Console.WriteLine($"Оцінка ReadEx: {12 - NMistR}");
            }
        }

        public override void Relax()
        {
            if ((MarkChoir >= 10) & (MarkDraw >= 10) & (MarkSport >= 10))
            {
                Console.WriteLine($"Оцінка RelaxEx: {(MarkChoir + MarkDraw + MarkSport) / 3}");
            }
        }
        public void Print()
        {
            double aver = ((MarkMath + MarkNat) / 2 + (12 - NMistW) + (12 - NMistR) + (MarkChoir + MarkDraw + MarkSport) / 3) / 4;
            if (aver >= 10 && aver <= 12)
            {
                Console.WriteLine($"{FirstName} {LastName} is {grade} pupil");
                Console.WriteLine($"Середня оцінка: {aver}");
            }
        }
    }

    public class GoodPupil : Pupil
    {
        public const string grade = "good";

        public GoodPupil(string fName, string lName, int mMath, int mNat, int mChoir, int mDraw, int mSport, int nMistW, int nMistR) : base(fName, lName, mMath, mNat, mChoir, mDraw, mSport, nMistW, nMistR) { }// конструктор

        public override void Study()
        {
            if ((MarkMath >= 7) & (MarkNat >= 7))
            {
                Console.WriteLine($"Оцінка StudyG: {(MarkMath + MarkNat) / 2}");
            }
        }

        public override void Write()
        {
            if (NMistW >= 0 && NMistW <= 5)
            {
                Console.WriteLine($"Оцінка WriteG: {12 - NMistW}");
            }
        }

        public override void Read()
        {
            if (NMistR >= 0 && NMistR <= 5)
            {
                Console.WriteLine($"Оцінка ReadG: {12 - NMistR}");
            }
        }

        public override void Relax()
        {
            if ((MarkChoir >= 7) & (MarkDraw >= 7) & (MarkSport >= 7))
            {
                Console.WriteLine($"Оцінка RelaxG: {(MarkChoir + MarkDraw + MarkSport) / 3}");
            }
        }

        public void Print()
        {
            double aver = ((MarkMath + MarkNat) / 2 + (12 - NMistW) + (12 - NMistR) + (MarkChoir + MarkDraw + MarkSport) / 3) / 4;
            if (aver >= 7 && aver <= 9)
            {
                Console.WriteLine($"{FirstName} {LastName} is {grade} pupil");
                Console.WriteLine($"Середня оцінка: {aver}");
            }
        }
    }

    public class BadPupil : Pupil
    {
        public const string grade = "bad";

        public BadPupil(string fName, string lName, int mMath, int mNat, int mChoir, int mDraw, int mSport, int nMistW, int nMistR) : base(fName, lName, mMath, mNat, mChoir, mDraw, mSport, nMistW, nMistR) { }// конструктор

        public override void Study()
        {
            if ((MarkMath >= 1) & (MarkNat >= 1))
            {
                Console.WriteLine($"Оцінка StudyB: {(MarkMath + MarkNat) / 2}");
            }
        }

        public override void Write()
        {
            if (NMistW >= 0 && NMistW <= 11)
            {
                Console.WriteLine($"Оцінка WriteB: {12 - NMistW}");
            }
        }

        public override void Read()
        {
            if (NMistR >= 0 && NMistR <= 11)
            {
                Console.WriteLine($"Оцінка ReadB: {12 - NMistR}");
            }
        }

        public override void Relax()
        {
            if ((MarkChoir >= 1) & (MarkDraw >= 1) & (MarkSport >= 1))
            {
                Console.WriteLine($"Оцінка RelaxB: {(MarkChoir + MarkDraw + MarkSport) / 3}");
            }
        }

        public void Print()
        {
            double aver = ((MarkMath + MarkNat) / 2 + (12 - NMistW) + (12 - NMistR) + (MarkChoir + MarkDraw + MarkSport) / 3) / 4;
            if (aver >= 1 && aver <= 6)
            {
                Console.WriteLine($"{FirstName} {LastName} is {grade} pupil");
                Console.WriteLine($"Середня оцінка: {aver}");
            }
        }
    }

    public class ClassRoom : Pupil
    {
        private static List<Pupil> myList;
        public Pupil p1, p2, p3, p4;

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4) : base()
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;

            myList = new List<Pupil>(4)
            {
                 new Pupil() { FirstName = "Lina", LastName = "Donchenko", MarkMath = 10, MarkNat = 10, MarkChoir = 11, MarkDraw = 12, MarkSport = 10, NMistW = 1, NMistR = 2 },
                 new Pupil() { FirstName = "Petro", LastName = "Petriv", MarkMath = 7, MarkNat = 9, MarkChoir = 7, MarkDraw = 8, MarkSport = 9, NMistW = 4, NMistR = 3 },
                 new Pupil() { FirstName = "Danya", LastName = "Bondarenko", MarkMath = 8, MarkNat = 8, MarkChoir = 7, MarkDraw = 7, MarkSport = 8, NMistW = 3, NMistR = 2 },
                 new Pupil() { FirstName = "Ivan", LastName = "Boyko", MarkMath = 6, MarkNat = 5, MarkChoir = 6, MarkDraw = 4, MarkSport = 8, NMistW = 5, NMistR = 6 }
            };
        }

        public static void Print()
        {
            foreach (Pupil pupil in myList)
            {
                Console.WriteLine(pupil.FirstName + " " + pupil.LastName + " " + pupil.MarkMath + " " + pupil.MarkNat + " " + pupil.MarkChoir + " " + pupil.MarkDraw + " " + pupil.MarkSport + " " + pupil.NMistW + " " + pupil.NMistR);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Pupil p1 = new Pupil("Lina", "Donchenko", 10, 10, 11, 12, 10, 1, 2);

            Pupil p2 = new Pupil("Petro", "Petriv", 7, 9, 7, 8, 9, 4, 3);

            Pupil p3 = new Pupil("Danya", "Bondarenko", 8, 8, 7, 7, 8, 3, 2);

            Pupil p4 = new Pupil("Ivan", "Boyko", 6, 5, 6, 4, 8, 5, 6);

            ExcelentPupil ep1 = new ExcelentPupil("Lina", "Donchenko", 10, 10, 11, 12, 10, 1, 2);
            ep1.Print();

            GoodPupil gp1 = new GoodPupil("Lina", "Donchenko", 10, 10, 11, 12, 10, 1, 2);
            gp1.Print();

            BadPupil bp1 = new BadPupil("Lina", "Donchenko", 10, 10, 11, 12, 10, 1, 2);
            bp1.Print();

            Console.WriteLine();

            ClassRoom cr1 = new ClassRoom(new Pupil("Lina", "Donchenko", 10, 10, 11, 12, 10, 1, 2),
                                          new Pupil("Petro", "Petriv", 7, 9, 7, 8, 9, 4, 3),
                                          new Pupil("Danya", "Bondarenko", 8, 8, 7, 7, 8, 3, 2),
                                          new Pupil("Ivan", "Boyko", 6, 5, 6, 4, 8, 5, 6));
            ClassRoom.Print();

            Console.WriteLine();

            // Оцінки першого учня
            p1.Study();
            p1.Write();
            p1.Read();
            p1.Relax();

            Console.WriteLine();

            // Оцінки другого учня
            p2.Study();
            p2.Write();
            p2.Read();
            p2.Relax();

            Console.WriteLine();

            // Оцінки третього учня
            p3.Study();
            p3.Write();
            p3.Read();
            p3.Relax();

            Console.WriteLine();

            // Оцінки четвертого учня
            p4.Study();
            p4.Write();
            p4.Read();
            p4.Relax();

            Console.ReadLine();
        }
    }
}