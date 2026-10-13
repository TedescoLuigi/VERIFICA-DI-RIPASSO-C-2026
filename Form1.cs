namespace VERIFICA_DI_RIPASSO___C__2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Decifrare la frase In un file di testo è memorizzata una serie di frasi cifrate con il cifrario di Cesare.
        //Ogni lettera è stata spostata di 3 posizioni in avanti nell’alfabeto.
        //Esempio: FLDR deve essere decifrato come CIAO


        private string Decifra(string fraseCifrata)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Leggere tutte le frasi presenti nel file e memorizzarle in un array di stringhe.


            List<string> righe = File.ReadAllLines("File.txt").ToList();
            string[] frasi = righe.ToArray();

            //Decifrare soltanto le frasi che si trovano in posizione pari nel file: 2ª, 4ª, 6ª, ...

            for (int i = 1; i < righe.Count; i += 2)
            {
                string fraseDecifrata = Decifra(righe[i]);
                righe[i] = fraseDecifrata;
            }

            if (File.Exists("Soluzioni.txt"))
            {
                using (StreamWriter sw = new StreamWriter("Soluzioni.txt"))
                {
                    foreach (string riga in righe)
                    {
                        sw.WriteLine(riga);
                    }
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
