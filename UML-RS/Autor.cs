namespace UMLRS{
    class Autor {

        int idAutora;
        String nick;
        String prijmeni;
        String jmeno;
        String email;

        private Bonus bonus = new Bonus(0);
        
        public Autor(string jmeno, string prijmeni){
            this.prijmeni = prijmeni;
            this.jmeno = jmeno;
            this.email = "nan";
            this.nick = "nan";
            this.idAutora = 1;
        }
        public int IdAutora{
            get{return this.idAutora;}
        }
        public String Nick{
            get{return this.nick;}
        }
        public String Prijmeni{
            get{return this.prijmeni;}
            set{this.prijmeni = value;}
        }
        public String Jmeno{
            get{return this.jmeno;}
            set{this.jmeno = value;}
        }
        public String Email{
            get{return this.email;}
            set{this.email = value;}
        }
        public Bonus Bonus{
            get{return this.bonus;}
            set{this.bonus = value;}
        }

        public void Vytvorit(){
            Console.WriteLine("Autor vytvořen...");
        }

        public void Smazat(){
            Console.WriteLine("Autor smazán...");
        }
        public void Editovat(){
            Console.WriteLine("Autor upraven...");
        }

        override public String ToString(){
            return ("  Jmeno: " + this.jmeno + "\tPříjmení: " + this.prijmeni + "\tBody: " + this.bonus );
        }

        
    }
}