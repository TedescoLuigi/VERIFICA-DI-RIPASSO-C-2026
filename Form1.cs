namespace VERIFICA_DI_RIPASSO___C__2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Decifrare la frase In un file di testo è memorizzata una serie di frasi cifrate con il cifrario di Cesare.


        private string Decifra(string fraseCifrata)
        {
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string fraseDecifrata = "";

            for (int i = 0; i < fraseCifrata.Length; i++)
            {
                for (int j = 0; i < alfabeto.Length; i++)
                {
                    if (alfabeto[j] == fraseCifrata[i])
                    {
                        int nuovaPosizione = (j - 3 + 26) % 26;
                        fraseDecifrata += alfabeto[nuovaPosizione];

                    }
                }

            }

            return fraseDecifrata;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Leggere tutte le frasi presenti nel file e memorizzarle in un array di stringhe.

            string[] righe = File.ReadAllLines("File.txt").ToArray();

            listBox1.Items.Clear()

            //Decifrare soltanto le frasi che si trovano in posizione pari nel file: 2ª, 4ª, 6ª, ...

            for (int i = 2; i < righe.Length; i += 2)
            {
                string fraseDecifrata = Decifra(righe[i]);
                righe[i] = fraseDecifrata;

                listBox1.Items.Add(fraseDecifrata);
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (File.Exists("File.txt"))
            {
                MessageBox.Show("FILE CARICATO CORRETTAMENTE");
            }
            else 
            {
                MessageBox.Show("FILE NON TROVATO CORRETTAMENTE");
            }
        }
    }
}
