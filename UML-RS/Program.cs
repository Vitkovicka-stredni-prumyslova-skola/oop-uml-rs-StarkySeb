namespace UMLRS{
    class Program {
        public  static void Main (string [] args){
                Autor nemcova = new Autor("Božena","Němcová");
                Clanek clanek1 = new Clanek(1, nemcova, "Babička", "prefix", "text_clanku");
                Console.WriteLine(nemcova.ToString());
                Console.WriteLine(clanek1.ToString());
                bonus.PridejBody(20);
                bonus.ToString();
        }
    }
}
