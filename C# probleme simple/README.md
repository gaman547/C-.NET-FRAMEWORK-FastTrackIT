primele probleme rezolvate in aproximativ 2 luni. in acest timp am invatat operatiile de baza , lucram cu consola.

problema 9 si 10 sunt in legatutra cu evenimente
9. Scrieti un program care monitorizeaza 3 foldere diferite, pentru orice modificari posibile, si afiseaza la consola modificarile care s-au produs.
10. Scrieti un program in care mai multi utilizatori pot sa introduca numele sau (fara a inchide programul). 
Pentru fiecare utilizator se va afisa textul "Bine ati venit ", folosind evenimente. Pentru utilizatorii cu nume "Marius" sau "Catalin" se va afisa textul "Alarma!", din alt eveniment.

celelalte probleme

1. Scrieti o aplicatie care primeste care citeste un numar la consola pe care apoi il tipareste de 4 ori pe o linie folosind spatiul ca si separator si apoi de 4 ori pe o linie fara spatiu. Faceti asta de 2 ori.

Exemplu:

Scrieti un numar: 25

Rezultatul este:

25 25 25 25

25252525

25 25 25 25

25252525

2. Scrieti o aplicatie de tip consola care sa culeaga urmatoarele informatii:

Nume, Prenume
Formula de adresare (Domnul/Doamna etc.)
Adresa
Judet
Cod Postal
Numar de telefon
email
Afisati pe consola informatiile in urmatoarea forma:

Persoana: Formula de adresare, Nume Prenume

Adresa: Adresa, Judet, Cod postal

Date de contact: Numar de telefon, email

3. Pornind de la un sir de numere, calculati fractiile elementelor pozitive, negatiive si care sunt 0. Tipariti valoarea zecimala pe o linie noua. Rezolvati problema pornind de la solutia disponibila aici.

Exemplu de date de intrare:

6
-4 3 -9 0 4 1    
Rezultat:

0.500000
0.333333
0.166667
Explicatie:

Prima valoare reprezinta numarul de elemente de intrare. Pe cel de-al doilea rand sunt introduse numerele, 2 numere negative, 3 numbere pozitive si un 0. Proportiile detectate sunt urmatoarele:

numere pozitive 3/6= 0.500000
numere negative 2/6 = 0.333333
zero 1/6= 0.166667

4. Scrietie o aplicatie in C# care primeste ca si argument o valoare si o distanta, tot ca si numar. Afisati un triunghi cu latura echivalenta cu distanta introdusa.

Exemplu:

Numar: 6

Distanta: 6

Rezultatul afisat este urmatorul

666666
66666
6666
666
66
6

5. Utilizatorul va introduce la consola o propozitie. Programul va citi propozitia si va numara cate cuvinte se gasesc in propozitie. Propozitia poate fi scrisa utilizand litere mari, litere mici (doar din alfabetul latin), cifre, si alte caractere (cum ar fi virgula, exclamatie, punct, etc. Numarul de cuvinte gasite va fi afisat la consola.

Exemplu. Utilizatorul va scrie la consola:

Aceasta este o propozitie cu 9 cuvinte, si o virgula!

Aplicatia va afisa la consola numarul 9.

6. FOLOSIND SIRURI. Pornind de la un sir de numere, impartiti aceste numere in 3 siruri, un sir e numere pozitive, un sir de numere negative si un sir de zerouri. Afisati la consola sirurile obtinute, si numarul de elemente in fiecare sir.

Exemplu de date de intrare:

7
-4 3 -9 0 4 1 0  
Ce se va afisa la consola:

Numere pozitive 3:
3 4 1
Numere negative 2:
-4 -9
Zerouri 2:
0 0
0.333333
0.166667
Explicatie:

Prima valoare reprezinta numarul de elemente de intrare. Pe cel de-al doilea rand sunt introduse numerele, 2 numere negative, 3 numbere pozitive si doi de 0. In program se vor crea 3 siruri, si fiecare numar se va salva in sirul respectiv. Dupa ce toate numerele au fost procesate, din fiecare sir se va afisa numarul de elemente si apoi elementele acestuia pe rand nou.

7. O universitate are urmatoarea forma de evaluare:

Fiecare student primeste o nota in intre 0 si 100.
Fiecare nota mai mica de 40 nu este nota de trecere.
Mihai este profesor la universitate si vrea sa rotunjeasca notele studentilor dupa cum urmeaza:

Daca diferenta dintre nota si urmatorul multitplu de 5 este mai mica decat 3 atunci rotunjeste la urmatorul multiplu de 5.
Daca nota este mai mica decat 38 atunci nu se aplica nici o rotunjire deoarece nu mai este nota de trecere
De exemplu nota 84 va fi rotunjita la 85 dar nota 29 nu va fi rotunjita deloc deoarece rotunjirea va fi o nota mai mica de nota minima de trecere 40.

Pornind de la numarul si lista de nota construiti un alogrimt care sa faca rotunjirile in mod automat.

Format de intrare

Prima linie contine a valoare intreaga, n, care reprzinta numarul de studenti.

Fiecare linie i din urmatoarele n linii reprezinta nota studentului ca si valoarea intreaga. note[i] v-a reprezenta nota studentului i.

Format de iesire

Pentru fiecare nota de intrare tipariti pe o linie nota rotunjita.

Exemplu de date de intrare

4
73
67
38
33
Exemplu de date de iesire

75
67
40
33
Explicatie

Studentul 1 a primit nota 73. Urmatorul multiplu de 5 dupa 73 este 75. Deoarece 75-73 <3, nota rotunjita a studentului va fi 75.
Studentul 2 a primit nota 67. Urmatorul multiplu de 5 dupa 67 este 70. Deoarece 70-67 =3, nota studentului ramane neschimbata.
, Studentul 3 a primit nota 38. Urmatorul multiplu de 5 dupa 37 este 40. Deoarece 40-38 <3, nota rotunjita a studentului va fi 40.
 Studentul 4 a primit nota 33. Deoarece nota este mai mica decat 38 nota nu va fi modificata astfel ca studentul va primi 33.

