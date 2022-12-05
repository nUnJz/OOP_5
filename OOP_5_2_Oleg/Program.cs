using System;

namespace OPP_5_2
{
    public class Pupil
    {
        private string firstName, lastName;
        private int markMath, markNat, markChoir, markDraw, markSport, nMistW, nMistR;

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

        public Pupil()
        {
            markMath = markNat = markChoir = markDraw = markSport = 1;
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
            Console.WriteLine($"Оцінка Study: {(markMath + markNat) / 2}");
        }

        public virtual void Write()
        {
            Console.WriteLine($"Оцінка Write: {12 - nMistW}");
        }

        public virtual void Read()
        {
            Console.WriteLine($"Оцінка Read: {12 - nMistR}");
        }

        public virtual void Relax()
        {
            Console.WriteLine($"Оцінка Relax: {(markChoir + markDraw + markSport) / 3}");
        }

        /*public virtual void Print()
        {
            double aver = ((markMath + markNat) / 2 + (12 - nMistW) + (12 - nMistR) + (markChoir + markDraw + markSport) / 3) / 4;
            if (aver >= 1 && aver <= 12)
            Console.WriteLine($"Середня оцінка: {aver}");
        }*/
    }

    public class ExcellentPupil : Pupil
    {
        public const string grade = "excelent";

        public ExcellentPupil(string fName, string lName, int mMath, int mNat, int mChoir, int mDraw, int mSport, int nMistW, int nMistR) : base(fName, lName, mMath, mNat, mChoir, mDraw, mSport, nMistW, nMistR) { }// конструктор

        public override void Study()
        {
            if ((MarkMath >= 10) & (MarkNat >= 10))
            {
                Console.WriteLine($"Оцінка StudyEx: {(MarkMath + MarkNat) / 2}");
            }

            else
            {
                Console.WriteLine($"Оцінка StudyEx: 0");
            }
        }

        public override void Write()
        {
            if (NMistW >= 0 && NMistW <= 2)
            {
                Console.WriteLine($"Оцінка WriteEx: {12 - NMistW}");
            }

            else
            {
                Console.WriteLine($"Оцінка WriteEx: 0");
            }
        }

        public override void Read()
        {
            if (NMistR >= 0 && NMistR <= 2)
            {
                Console.WriteLine($"Оцінка ReadEx: {12 - NMistR}");
            }

            else
            {
                Console.WriteLine($"Оцінка ReadEx: 0");
            }
        }

        public override void Relax()
        {
            if ((MarkChoir >= 10) & (MarkDraw >= 10) & (MarkSport >= 10))
            {
                Console.WriteLine($"Оцінка RelaxEx: {(MarkChoir + MarkDraw + MarkSport) / 3}");
            }

            else
            {
                Console.WriteLine($"Оцінка RelaxEx: {0}");
            }
        }
        public void Print()
        {
            double aver = ((MarkMath + MarkNat) / 2 + (12 - NMistW) + (12 - NMistR) + (MarkChoir + MarkDraw + MarkSport) / 3) / 4;
            if (aver >= 10 && aver <= 12)
            {
                Console.WriteLine($"Середня оцінка: {aver}");
                Console.WriteLine($"{FirstName} {LastName} is {grade} pupil");
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
                double markStudyG = (MarkMath + MarkNat) / 2;
                Console.WriteLine($"Оцінка StudyG: {markStudyG}");
            }

            else
            {
                // double markStudyG = 0;
                Console.WriteLine($"Оцінка StudyG: не визначається");
            }
        }

        public override void Write()
        {
            if (NMistW >= 0 && NMistW <= 5)
            {
                double markWriteG = 12 - NMistW;
                Console.WriteLine($"Оцінка WriteG: {markWriteG}");
            }

            else
            {
                double markWriteG = 0;
                Console.WriteLine($"Оцінка WriteG: {markWriteG}");
            }
        }

        public override void Read()
        {
            if (NMistR >= 0 && NMistR <= 5)
            {
                double markReadG = 12 - NMistR;
                Console.WriteLine($"Оцінка ReadG: {markReadG}");
            }

            else
            {
                double markReadG = 0;
                Console.WriteLine($"Оцінка ReadG: {markReadG}");
            }
        }

        public override void Relax()
        {
            if ((MarkChoir >= 7) & (MarkDraw >= 7) & (MarkSport >= 7))
            {
                double markRelaxG = (MarkChoir + MarkDraw + MarkSport) / 3;
                Console.WriteLine($"Оцінка RelaxG: {markRelaxG}");
            }

            else
            {
                // double markRelaxG = 0;
                Console.WriteLine($"Оцінка RelaxG: не визначається");
            }
        }
        public void Print()
        {
            double aver = ((MarkMath + MarkNat) / 2 + (12 - NMistW) + (12 - NMistR) + (MarkChoir + MarkDraw + MarkSport) / 3) / 4;
            if (aver >= 7 && aver <= 9)
            {
                Console.WriteLine($"Середня оцінка: {aver}");
                Console.WriteLine($"{FirstName} {LastName} is {grade} pupil");
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
                double markStudyB = (MarkMath + MarkNat) / 2;
                Console.WriteLine($"Оцінка StudyB: {markStudyB}");
            }

            else
            {
                double markStudyB = 0;
                Console.WriteLine($"Оцінка StudyB: {markStudyB}");
            }
        }

        public override void Write()
        {
            if (NMistW >= 0 && NMistW <= 11)
            {
                double markWriteB = 12 - NMistW;
                Console.WriteLine($"Оцінка WriteB: {markWriteB}");
            }

            else
            {
                double markWriteB = 0;
                Console.WriteLine($"Оцінка WriteB: {markWriteB}");
            }
        }

        public override void Read()
        {
            if (NMistR >= 0 && NMistR <= 11)
            {
                double markReadB = 12 - NMistR;
                Console.WriteLine($"Оцінка ReadB: {markReadB}");
            }

            else
            {
                double markReadB = 0;
                Console.WriteLine($"Оцінка ReadB: {markReadB}");
            }
        }

        public override void Relax()
        {
            if ((MarkChoir >= 1) & (MarkDraw >= 1) & (MarkSport >= 1))
            {
                double markRelaxB = (MarkChoir + MarkDraw + MarkSport) / 3;
                Console.WriteLine($"Оцінка RelaxB: {markRelaxB}");
            }

            else
            {
                double markRelaxB = 0;
                Console.WriteLine($"Оцінка RelaxB: {markRelaxB}");
            }
        }

        public void Print()
        {
            double aver = ((MarkMath + MarkNat) / 2 + (12 - NMistW) + (12 - NMistR) + (MarkChoir + MarkDraw + MarkSport) / 3) / 4;
            if (aver >= 1 && aver <= 6)
            {
                Console.WriteLine($"Середня оцінка: {aver}");
                Console.WriteLine($"{FirstName} {LastName} is {grade} pupil");
            }
        }
    }

    public class ClassRoom : Pupil
    {
        private static List<Pupil> myList;
        public Pupil p1, p2, p3, p4;// = new Pupil("Lina", "Donchenko", 10, 10, 11, 12, 10, 1, 2);
        //Pupil p2;// = new Pupil("Petro", "Petriv", 7, 9, 7, 8, 9, 4, 3);
        //Pupil p3;// = new Pupil("Danya", "Bondarenko", 8, 8, 7, 7, 8, 3, 2);
        //Pupil p4;// = new Pupil("Ivan", "Boyko", 6, 5, 6, 4, 8, 5, 6);

        public ClassRoom(/*string fName, string lName, int mMath, int mNat, int mChoir, int mDraw, int mSport, int nMistW, int nMistR,*/ Pupil p1, Pupil p2, Pupil p3, Pupil p4) : base(/*fName, lName, mMath, mNat, mChoir, mDraw, mSport, nMistW, nMistR*/)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;

            myList = new List<Pupil>
            {
                new Pupil {FirstName = "Lina", LastName = "Donchenko", MarkMath = 10, MarkNat = 10, MarkChoir = 11, MarkDraw = 12, MarkSport = 10, NMistW = 1, NMistR = 2},
                new Pupil {FirstName = "Petro", LastName = "Petriv", MarkMath = 7, MarkNat = 9, MarkChoir = 7, MarkDraw = 8, MarkSport = 9, NMistW = 4, NMistR = 3},
                new Pupil {FirstName = "Danya", LastName = "Bondarenko", MarkMath = 8, MarkNat = 8, MarkChoir = 7, MarkDraw = 7, MarkSport = 8, NMistW = 3, NMistR = 2},
                new Pupil {FirstName = "Ivan", LastName = "Boyko", MarkMath = 6, MarkNat = 5, MarkChoir = 6, MarkDraw = 4, MarkSport = 8, NMistW = 5, NMistR = 6}
            };

            /*for (int pupil = 0; pupil < 4; pupil++)
            {
                // виклик конструктора з 9 параметрами
                myList[pupil] = new Pupil(fName, lName, mMath, mNat, mChoir, mDraw, mSport, nMistW, nMistR);
            }*/
        }

        public static void Print()
        {
            foreach (Pupil pupil in myList)
            {
                Console.WriteLine(pupil.FirstName + pupil.LastName + pupil.MarkMath + pupil.MarkNat + pupil.MarkChoir + pupil.MarkDraw + pupil.MarkSport + pupil.NMistW + pupil.NMistR);

                /*Console.WriteLine("Ім'я" + " " + pupil.ToString() + "\n",
                                    "Прізвище" + " " + pupil.ToString() + "\n",
                                    "Математика" + " " + pupil.ToString() + "\n",
                                    "Природознавство" + " " + pupil.ToString() + "\n",
                                    "Хор" + " " + pupil.ToString() + "\n",
                                    "Малювання" + " " + pupil.ToString() + "\n",
                                    "Спорт" + " " + pupil.ToString() + "\n",
                                    "Помилки з письма" + " " + pupil.ToString() + "\n",
                                    "Помилки з читання" + " " + pupil.ToString() + "\n");*/
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Pupil p1 = new Pupil("Lina", "Donchenko", 10, 10, 11, 12, 10, 1, 2);
            p1.Study();
            p1.Write();
            p1.Read();
            p1.Relax();
            //p1.Print();

            Console.WriteLine();

            Pupil p2 = new Pupil("Petro", "Petriv", 7, 9, 7, 8, 9, 4, 3);
            p2.Study();
            p2.Write();
            p2.Read();
            p2.Relax();
            //p2.Print();

            Console.WriteLine();

            Pupil p3 = new Pupil("Danya", "Bondarenko", 8, 8, 7, 7, 8, 3, 2);
            p3.Study();
            p3.Write();
            p3.Read();
            p3.Relax();
            //p3.Print();

            Console.WriteLine();

            Pupil p4 = new Pupil("Ivan", "Boyko", 6, 5, 6, 4, 8, 5, 6);
            p4.Study();
            p4.Write();
            p4.Read();
            p4.Relax();
            //p4.Print();

            Console.WriteLine();

            ExcellentPupil ep1 = new ExcellentPupil("Lina", "Donchenko", 10, 10, 11, 12, 10, 1, 2);

            ep1.Study();
            ep1.Write();
            ep1.Read();
            ep1.Relax();
            ep1.Print();

            Console.WriteLine();

            GoodPupil gp1 = new GoodPupil("Lina", "Donchenko", 10, 10, 11, 12, 10, 1, 2);
            gp1.Study();
            gp1.Write();
            gp1.Read();
            gp1.Relax();
            gp1.Print();

            Console.WriteLine();

            BadPupil bp1 = new BadPupil("Lina", "Donchenko", 10, 10, 11, 12, 10, 1, 2);
            bp1.Study();
            bp1.Write();
            bp1.Read();
            bp1.Relax();
            bp1.Print();

            Console.WriteLine();

            ClassRoom cr1 = new ClassRoom(new Pupil("Lina", "Donchenko", 10, 10, 11, 12, 10, 1, 2), new Pupil("Petro", "Petriv", 7, 9, 7, 8, 9, 4, 3), new Pupil("Danya", "Bondarenko", 8, 8, 7, 7, 8, 3, 2), new Pupil("Ivan", "Boyko", 6, 5, 6, 4, 8, 5, 6));
            ClassRoom.Print();

            Console.ReadLine();
        }
    }
}