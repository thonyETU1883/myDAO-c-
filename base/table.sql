--base de donnee : postgres
--nom base de donnee : dao

CREATE TABLE personnel(
    idpersonnel VARCHAR(100) DEFAULT 'personnel' || nextval('personnelsequence')::TEXT PRIMARY KEY,
    nompersonnel VARCHAR(50),
    poste VARCHAR(50)
);


--------------------