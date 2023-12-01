namespace dao.Models;


public class Personnel : Intermediary{

    [Column("idpersonnel")]
    [Key]
    String? idpersonnel;

    [Column("nompersonnel")]
    String? nompersonnel;

    [Column("poste")]
    String? poste;

    public Personnel(String idpersonnel,String nompersonnel,String poste){
        this.idpersonnel = idpersonnel;
        this.nompersonnel = nompersonnel;
        this.poste = poste;
    }
    public Personnel(){}
}