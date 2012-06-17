using System;
using System.Collections.Generic;

using System.Web;

public class MojHash
{
	public static string hash_alg(string lozinkaUnos, string salt)// moja funkcija koja prima lozinku koju je korisnik unio i random broj koji se izgenerirao
    {
        string lozinka = Util.SHA256(lozinkaUnos);  //util.sha256 je hash mašina(funkcija koja ima algoritam za stvaranje hash coda) koja stvara hashiranu lozinku 
                                                    //kojoj šaljemo lozinku koju je korisnik unio
        lozinka=lozinka+salt;   // onda tu lozinku posolimo sa random brojem kojeg smo stvorili
        lozinka = Util.SHA256(lozinka); //i onda sve to opet bacimo u hash mašinu
        return lozinka; //i vratimo hashiranu lozinku(znači imamo hash lozinku koju hashiramo, pa ju posolimo, pa sve to zajedno opet hashiramo) 
	}
}

