using System;
using System.Text;

namespace p3
{
    class Program
    {
        class Masina
        {
            private readonly string serieSasiu;
            private int nrKm = 0;
            private readonly string marca;
            private readonly string model;
            private string combustibil;
            public Masina(string serieSasiu, string marca, string model)
            {
                this.serieSasiu = serieSasiu;
                this.marca = marca;
                this.model = model;
            }
            public Masina(string serieSasiu, string marca, string model, int nrKm, string combustibil) : this(serieSasiu, marca, model)
            {
                this.nrKm = nrKm;
                this.combustibil = combustibil;

            }
            public string Combustibil
            {
                set
                {
                    this.combustibil = value;
                }
                get
                {

                    return combustibil;
                }
            }
            public string NrKMVerificare => $"Masina a efectuat {nrKm} km.";
            public string addKmParcursi(int nrKmparcursi)
            {
                if (nrKmparcursi < 0)
                {
                    return $"Nr de km nu poate sa fie negativ";

                }
                nrKm += nrKmparcursi;
                return $"Km au fost adaugati cu succes, iar masina dvs a efecutat: {nrKm} km.";


            }
            public override string ToString()
            {
                return $@"Serie masina:{serieSasiu};
Marca:{marca};
Model:{model};
NrKm:{nrKm};
Combustibil:{combustibil}";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s1 = "Helloz";
            string s2 = "Helloa";
            int result = string.Compare(s1, s2,false);
            Console.WriteLine(result);
            Console.WriteLine(s1 == s2);

            string c1="heii,tuu";
            string c2 = "heii,  tuu";
            Console.WriteLine(c1.Contains(" tuu"));
            Console.WriteLine(c2.Contains(" tuu"));
            Console.WriteLine(c2.EndsWith(" tuu"));
            Console.WriteLine(c2.StartsWith(" tuu"));
            string c3 = "hEii,tuu";
            string c4 = "heii,tuu";
            Console.WriteLine(c3.Equals(c4, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(c3.ToLower()==c4.ToLower());
            Masina m1= new Masina("MRS1111298", "Mercedes", "CLS", 12332, "Benzina");
            Console.WriteLine(string.Format("He{1}o you,Ho{0}a{2} you? {3}, {4} . It is {5}", "w ", "ll", "are",3,4,m1));
            string s111 = "Ana";
            String s22 = $"Hello,{s111}";
            Console.WriteLine(s2);
            string addunr = s2.PadLeft(23);
            string addun1r = s2.PadRight(23);
            string j3 = addunr.Trim();
            //se poate si doar la stanga sau dreapta
            Console.WriteLine(addunr);
            Console.WriteLine(addun1r);
            Console.WriteLine(j3);
            string text = "he self-study lessons in this section are written and organised according to the levels of the Common European Framework of Reference for languages (CEFR). There are different types of texts and interactive exercises that practise the reading skills you need to do well in your studies, to get ahead at work and to communicate in English in your free time.";
            string[] words = text.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            //TrimEntries
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            string lip = string.Join("  ", words);
            Console.WriteLine(lip);
            string a = @"iei{iiii""";
            string a2 = $@"ieiiiii{{{a}}}";
            Console.WriteLine(a);
            Console.WriteLine(a2);

            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.UtcNow;
            DateTimeOffset a3= DateTime.Now;
            DateTimeOffset b4= DateTime.UtcNow;
            TimeSpan dif = b4 - d1;
            Console.WriteLine(dif);

            //StringBuilder reprezinta un string derivat din object, iar valoarea acestuia este mutabila 
            //StringBuilder val max de la int 32, se initiaza cu dimensiunea 16 default(pentru o )
            //StringBuilder s=new StringBuilder("caractere", lungimea maxima(int32));
            //s.Append,s.AppendFormat, s.Insert(index,"sir"),s.Replace("caracterul inlocuit","caracterul care inlocuieste"),s.appendLine();)  sb.Clear(); 



            // Create a StringBuilder that expects to hold 50 characters.
            // Initialize the StringBuilder with "ABC".
            StringBuilder sb = new StringBuilder("ABC", 3);
            StringBuilder sb2 = new StringBuilder("ABC", 3);
            Console.WriteLine(sb == sb2);
            //false
            //memoria este dinamica se redimensioneaza (daca dimensiunea lui este de 5 si iar lungimea lui este 4 si mai adaugam inca 3 caractere lungimea/dimensiunea lui se dubleaza automat, acest lucru se poate intampla pana cand atingem valoarea masina a lui int32)
            // Append three characters (D, E, and F) to the end of the StringBuilder.
            sb.Append(new char[] { 'D', 'E', 'F' });
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
            sb.Append( " asdasd");
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());


            sb.AppendFormat("GHI{0}{1}", 'J', 'k');
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
            sb.Insert(2, "Alphabet: ");
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
            sb.Replace('k', 'K');
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
            sb.Remove(1, 10);
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
            Numaram(sb);
        
        
        }
        static void Numaram(StringBuilder sb) {

           
                int nrLit1 = 0;
               int nrSpatii = 0;
                int nrSemne = 0;
               for(int i=0;i<sb.Length;i++)
                {
                char a = sb[i];
                if (Char.IsLetter(a)) { nrLit1++;
                    Console.WriteLine(Char.IsLetter(a));
                }
                    if (Char.IsWhiteSpace(a)) nrSpatii++;
                    if (Char.IsPunctuation(a)) nrSemne++;
                }

           
            Console.WriteLine($"Numarul de litere:{nrLit1}");
            Console.WriteLine($"Numarul de saptii:{nrSpatii}");
            Console.WriteLine($"Numarul de semne de punctuatie:{nrSemne}");
        }   
      }    

    }

