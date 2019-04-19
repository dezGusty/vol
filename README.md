#App
# Bucuria Darului
Cerinte:
  - [x] o aplicatie care pentru voluntari ;
  - [] o aplicatie pentru beneficiari ;
  - [] o aplicatie pentru sponsori ;

### Aplicatie voluntari/eveniment
 Voluntar-campuri:
 
  - [x]  nume(nume de familie+prenume); 
  - [x] varsta;
  - [x] gen
  - [x] adresa(strada,numar,localitate,tara);
  - [x] date de contact(mail,nr. tel);
  - [x] informatii aditionale(detine masina,are permis);
  - [x] ocupatie;
  -[x]  domeniul in care vrea sa ajute la cantina;
  - [x] disponibilitate(zile si intervale de timp in care poate activa);
  - [x] daca e activ ;
  - [x] contract(daca are?,informatii-data inregistrarii,perioada);
  -[x]  data nasterii;
  - [x] alerta zi de nastere;
  -[x] alerta expirare contract;
  -[x] pontaj;
  - [x] comentatiu;
 
Eveniment campuri:
  - [x] numele;
  - [x] perioada desfasurarii;
  - [x] tipul evenimentului(targ,bucatarie,impachetat pachete);
  - [x] numarul de voluntari necesari;
  - [x]  data desfasurarii.

### Aplicatie sponsori/beneficiar
Sponsor campuri:
  -  cand a avut loc sponsorizarea;
  - in ce a constat(bani/bunuri/altele);
  - informatii contracr(daca exista un contract?,pe ce perioada);
  -   alerta expirare contract;
  -   date de contact(mail/nr. tel);
  -  raport pe 6 luni.
  
Beneficiar campuri:
 -  nume,prenume,data nasterii,gen;
 -  numele capului de familie;
 -  status(activ/inactiv);
 -  locatie(a,b);
 -  pachet saptamanal;
 -  sofer pentru livrare la domiciliu;
 - acord GDPR;
 -  adresa;
 -  act identitate(data expirare,cnp);
 -  marca(cerere id,ancheta,contract,perioada contract);
 - nr portii;
 -  date iesire din evidenta+motiv(deces,angajare,directia asist. sociala);
 -  loc nastere,data nasterii,varsta;
 -  date de contact(telefon);
 -  studii;
 -  profesie;
 -  ocupatie;
 -  vechime;
 -  starea sanatatii;
 -  handicap(da/nu);
 -  afectiuni cronice(da/nu);
 -  dependente;
 -  asigurat(da/nu);
 - card sanatate(da/nu);
 - stare civila;
 - nume sotie/sot/concubim;
 -  tip locuinta(chirie,gazduit de cineva,mostenire,etc);
 - persoana fara adapost(da/nu);
 - raport pe 6 luni.

Registru:
-  marca(cerere id,ancheta,contract,perioada contract);
-  marca(cerere id,ancheta,contract,perioada contract);
 
### Forma curenta in care se pastreaza informatiile
Baza de date(fisier ecel) curenta pentru voluntari contine:
- numele;
- prenumele;
- domiciliu;
- act identitat;
- telefon;
- nr.contract;
- proiecte;
- program lucru;
- activ(da,nu);

Fisierul ecel pt evenimente:
- denumire;
- data/interval;
- voluntari;
- sponsori;
- parteneri.

Fisierul ecel pt sponsori:
- cand a avut loc sponsorizarea;
- in ce a constat(bunuri/bani=>suma).

### Aplicatie sponsori/beneficiar
##### Clase:
- Program(main);
- volunteer;
- event;
- db;
 -date;
 ##### Metode:
 - [x] adauga voluntar/eveniment;
 - [x] sterge voluntar/eveniment;
 - [x] arata toti voluntarii/toate evenimentele;
 - [x] alerta zi de nastere voluntari;
 - [x] alerta expirare contract;
 - [] editeaza un voluntar/eveniment;
