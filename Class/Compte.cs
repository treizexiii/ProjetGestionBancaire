namespace ProjetCompteBancaire.Class
{
    public class Compte
    {
        private int _compteID { get; set; }
        private string _compteNom { get; set; }
        private float _solde { get; set; }
        private float _decouvertAutorise { get; set; }

        public Compte()
        {
        }

        public Compte(int compteID, string compteNom, float solde, float decouvertAutorise)
        {
            this._compteID = compteID;
            this._compteNom = compteNom;
            this._solde = solde;
            this._decouvertAutorise = decouvertAutorise;
        }

        public override string ToString()
        {
            return $"{this._compteID}, {this._compteNom}, {this._solde}, {this._decouvertAutorise}";
        }

        public float Crediter(float montant)
        {
            this._solde += montant;
            return this._solde;
        }

        public float Debiter(float montant)
        {
            if (CheckDecouvert(montant) == true)
            {
                this._solde -= montant;
            }
            return this._solde;
        }

        public float Transfert(float montant, Compte CompteDestinataire)
        {
            if (CheckDecouvert(montant) == true)
            {
                this.Debiter(montant);
                CompteDestinataire.Crediter(montant);
            }
            return this._solde;
        }

        public bool Superieur(Compte CompteDestinataire)
        {
            bool superieur = false;
            if (this._solde > CompteDestinataire._solde)
            {
                superieur = true;
            }
            return superieur;
        }

        public bool CheckDecouvert(float montant)
        {
            bool check = false;
            float newSolde = this._solde - montant;
            if (newSolde > this._decouvertAutorise)
            {
                check = true;
            }
            return check;
        }

    }
}
