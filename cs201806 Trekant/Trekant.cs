namespace cs201806_Trekant
{
    class Trekant
    {
        // Grundlinje
        private int _Grundlinje;
        public int Grundlinje
        {
            get { return _Grundlinje; }
            private set { _Grundlinje = value; }
        }
        // Højde
        private int _Højde;
        public int Højde
        {
            get { return _Højde; }
            private set { _Højde = value; }
        }
        // Constructor
        public Trekant(int Grundlinje, int Højde)
        {
            this._Grundlinje = Grundlinje;
            this._Højde = Højde;
        }
        // Metode
        public double Areal ()
        {
            return (this._Grundlinje * this._Højde * 0.5);
        }
    }
}
