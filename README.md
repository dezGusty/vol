#App
# Bucuria Darului
Cerinte:
  - [x] o aplicatie care pentru voluntari ;
  - [x] o aplicatie pentru beneficiari ;
  - [x] o aplicatie pentru sponsori ;

### Aplicatie voluntari/eveniment
 Voluntar-campuri:
 
  - [x]  nume(nume de familie+prenume); 
  - [x] varsta;
  - [x] gen
  - [x] adresa(strada,numar,localitate,tara);
  - [x] date de contact(mail,nr. tel);
  - [x] informatii aditionale(detine masina,are permis);
  - [x] ocupatie;
  - [x]  domeniul in care vrea sa ajute la cantina;
  - [x] disponibilitate(zile si intervale de timp in care poate activa);
  - [x] daca e activ ;
  - [x] contract(daca are?,informatii-data inregistrarii,perioada);
  - [x]  data nasterii;
  - [x] alerta zi de nastere;
  - [x] alerta expirare contract;
  - [x] pontaj;
  - [x] comentatiu;
 
Eveniment campuri:
  - [x] numele;
  - [x] perioada desfasurarii;
  - [x] tipul evenimentului(targ,bucatarie,impachetat pachete);
  - [x] numarul de voluntari necesari;
  - [x]  data desfasurarii.

### Aplicatie sponsori/beneficiar
Sponsor campuri:
 - [x] cand a avut loc sponsorizarea;
 - [x] in ce a constat(bani/bunuri/altele);
 - [x] informatii contracr(daca exista un contract?,pe ce perioada);
 - [x] alerta expirare contract;
 - [x] date de contact(mail/nr. tel);
 - [x] raport pe 6 luni.
  
Beneficiar campuri:
 - [x] nume,prenume,data nasterii,gen;
 - [x] numele capului de familie;
 - [x] status(activ/inactiv);
 - [x] locatie(a,b);
 - [x] pachet saptamanal;
 - [x] sofer pentru livrare la domiciliu;
 - [x] acord GDPR;
 - [x] adresa;
 - [x] act identitate(data expirare,cnp);
 - [x]  marca(cerere id,ancheta,contract,perioada contract);
 - [x] nr. portii;
 - [x] date iesire din evidenta+motiv(deces,angajare,directia asist. sociala);
 - [x] loc nastere,data nasterii,varsta;
 - [x] date de contact(telefon);
 - [x] studii;
 - [x] profesie;
 - [x] ocupatie;
 - [x] vechime;
 - [x] starea sanatatii;
 - [x] handicap(da/nu);
 - [x] afectiuni cronice(da/nu);
 - [x] dependente;
 - [x] asigurat(da/nu);
 - [x] card sanatate(da/nu);
 - [x] stare civila;
 - [x] nume sotie/sot/concubim;
 - [x] tip locuinta(chirie,gazduit de cineva,mostenire,etc);
 - [x] persoana fara adapost(da/nu);
 - [x] raport pe 6 luni.

Registru:
- [x]  marca(cerere id,ancheta,contract,perioada contract);
- [x]  marca(cerere id,ancheta,contract,perioada contract);
 
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
- beneficiari;
- sponsori
- db;
 -date;
 ##### Metode:
 - [x] adauga voluntar/eveniment/sponsori/beneficiari;
 - [x] sterge voluntar/eveniment/sponsori/beneficiari;
 - [x] arata toti voluntarii/toate evenimentele/toti sponsori/toti beneficiari;
 - [x] alerta zi de nastere voluntari;
 - [x] alerta expirare contract(voluntari,beneficiari,sponsori);
 - [x] editeaza un voluntar/eveniment/sponsor/beneficiari;
 - [x] export date in excel(voluntari,evenimente,sponsori,beneficiari).
