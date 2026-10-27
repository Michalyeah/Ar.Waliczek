LEKCJA 22



Zadanie 22.1

Ryzyko to możliwość wystąpienia zdarzenia, które może źle wpłynąć na projekt, produkt albo testowanie.

Rejestr ryzyk to dokument, w którym zapisuje się ryzyka, ich rodzaj, wpływ, priorytet i działania zapobiegawcze.



Zadanie 22.2

Ryzyka projektowe: opóźnienie środowiska testowego, nieobecność testera.

Ryzyka produktowe: błędne obliczanie terminu zwrotu książki, zły status dostępności książki.

Ryzyka bezpieczeństwa informacji: nieuprawniony dostęp do danych użytkowników, utrata danych przez brak kopii zapasowej.



Zadanie 22.3

Przykładowe ryzyka dla aplikacji biblioteki szkolnej:

R1 brak środowiska testowego

R2 nieobecność testera

R3 błędny status książki

R4 nieuprawniony dostęp do danych

R5 utrata danych o wypożyczeniach



Zadanie 22.4

R1 wpływ duży, priorytet wysoki, działanie: przygotowanie zapasowego środowiska.

R2 wpływ średni, priorytet średni, działanie: wyznaczenie zastępcy.

R3 wpływ duży, priorytet wysoki, działanie: dodatkowe testy statusów.

R4 wpływ bardzo duży, priorytet krytyczny, działanie: kontrola uprawnień.

R5 wpływ duży, priorytet wysoki, działanie: wykonywanie kopii zapasowych.



LEKCJA 23



Zadanie 23.1

Trzy działania ograniczające ryzyko braku środowiska testowego:

1\. przygotowanie zapasowego środowiska

2\. wcześniejsze sprawdzenie działania serwera

3\. zmiana kolejności testów do czasu naprawy



Zadanie 23.2

Przykładowe uzupełnienie rejestru:

R1 status: w trakcie ograniczania, odpowiedzialny: administrator

R2 status: monitorowane, odpowiedzialny: kierownik testów

R3 status: otwarte, odpowiedzialny: programista

R4 status: w trakcie ograniczania, odpowiedzialny: specjalista ds. bezpieczeństwa

R5 status: monitorowane, odpowiedzialny: administrator bazy danych



Zadanie 23.3

Raport błędów pomaga aktualizować rejestr ryzyk, bo pokazuje, gdzie są problemy. Jeśli w jednym module pojawia się dużo błędów, to ryzyko dla tego modułu rośnie. Jeśli błędy zostaną naprawione, poziom ryzyka może się zmniejszyć.



Zadanie 23.4

Przykładowy raport błędów:

B01 brak możliwości logowania, status otwarty, priorytet wysoki

B02 błędny status zwróconej książki, status w naprawie, priorytet wysoki

B03 niedziałające wyszukiwanie, status otwarty, priorytet średni

B04 dostęp ucznia do panelu administratora, status otwarty, priorytet krytyczny



LEKCJA 24



Zadanie 24.1

Raport błędów tworzy się po to, aby zapisać wykryte defekty, ułatwić ich analizę, ustalić kolejność napraw i śledzić postęp prac.



Zadanie 24.2

Przykładowe trzy defekty:

B01 komponent logowanie, status otwarty, priorytet wysoki

B02 komponent wypożyczenia, status w naprawie, priorytet wysoki

B03 komponent katalog, status naprawiony, priorytet średni



Zadanie 24.3

Nowy - błąd został zgłoszony.

W analizie - trwa sprawdzanie przyczyny.

W trakcie naprawy - programista usuwa błąd.

Naprawiony - poprawka została wprowadzona.

Zamknięty - poprawka została sprawdzona i zgłoszenie zakończono.



Zadanie 24.4

Status mówi, na jakim etapie jest zgłoszenie.

Priorytet mówi, jak pilnie trzeba zająć się błędem.



LEKCJA 25



Zadanie 25.1





Zadanie 25.2

Najbardziej podatny na błędy jest moduł logowania, ponieważ ma najwięcej zgłoszeń. Przykładowo można przyjąć: logowanie 120 błędów, wypożyczenia 95, katalog 70, konta użytkowników 40, powiadomienia 20.



Zadanie 25.3

1\. Wszystkie błędy wysokiego priorytetu zostały zamknięte, więc trzeba sprawdzić poprawki testami regresji.

2\. Nadal są otwarte błędy średniego i niskiego priorytetu, więc trzeba je dalej analizować.

3\. Moduł logowania wymaga dodatkowych testów, bo ma najwięcej błędów.



Zadanie 25.4

Dwie metryki do dodania:

1\. średni czas naprawy defektu

2\. liczba ponownie otwartych defektów



LEKCJA 26



Zadanie 26.1

Celem raportu końcowego jest podsumowanie testów aplikacji szkolnej, liczby wykonanych scenariuszy, znalezionych defektów i problemów oraz pomoc w podjęciu decyzji o wdrożeniu.



Zadanie 26.2

Przydzielone i wykonane scenariusze:

Tester 1 - 234 i 234

Tester 2 - 98 i 98

Tester 3 - 113 i 113

Tester 4 - 24 i 24

Razem - 469 i 469



Zadanie 26.3

Wyniki testów:

pozytywne 395

negatywne 30

zablokowane 44

razem 469



Zadanie 26.4

Dokumenty powiązane z raportem testów: plan testów, wymagania, scenariusze testowe, lista kontrolna, rejestr ryzyk, raport błędów, harmonogram, dowody testów.



LEKCJA 27



Zadanie 27.1

Przykładowa ocena kryteriów:

100 procent testów wysokiego priorytetu zakończono pozytywnie - tak

65 procent testów średniego priorytetu zakończono pozytywnie - tak

brak otwartych defektów krytycznych - tak

Wniosek: przy takich danych kryteria są spełnione.



Zadanie 27.2

Trzy czynniki blokujące postęp testów:

1\. niedostępne środowisko testowe

2\. brak danych testowych

3\. awaria narzędzia testowego



Zadanie 27.3

Rekomendacja pozytywna: aplikację można wdrożyć, bo nie ma błędów blokujących.

Rekomendacja negatywna: aplikacji nie należy wdrażać, bo są błędy krytyczne.

Rekomendacja warunkowa: wdrożenie jest możliwe po usunięciu błędów wysokiego priorytetu i ponownych testach.



Zadanie 27.4

Załączniki do raportu końcowego: plan testów, harmonogram, scenariusze, wyniki testów, rejestr defektów, rejestr ryzyk, raporty dzienne, zrzuty ekranu.



LEKCJA 28



Zadanie 28.1

Przykładowy raport błędów modułu logowania:

L01 logowanie poprawnymi danymi nie działa, zamiast zalogowania pojawia się komunikat o błędnym haśle

L02 po wielu błędnych próbach nie ma blokady logowania

L03 przy pustym haśle pojawia się zły komunikat

L04 na przycisku jest literówka

L05 przycisk pokaż hasło nie działa



Zadanie 28.2

L01 status otwarty, priorytet wysoki

L02 status w analizie, priorytet wysoki

L03 status do wyjaśnienia, priorytet średni

L04 status otwarty, priorytet niski

L05 status otwarty, priorytet średni



Zadanie 28.3

W module logowania wykryto 5 defektów. Dwa mają wysoki priorytet, dwa średni i jeden niski. Najpilniej trzeba naprawić błędy dotyczące logowania i bezpieczeństwa.



Zadanie 28.4

Cel raportu: sprawdzenie poprawności logowania użytkowników, walidacji danych i zabezpieczeń.

Zakres: logowanie poprawnymi i błędnymi danymi, puste pola, pokazywanie hasła, ograniczenie liczby prób.

Wyniki: 15 pozytywnych, 4 negatywne, 1 zablokowany, razem 20.

Wniosek: moduł wymaga poprawek i ponownych testów.



LEKCJA 29



Zadanie 29.1

96 z 120 pozytywnych to 80 procent.

14 z 120 negatywnych to 11,67 procent.

10 z 120 zablokowanych to 8,33 procent.



Zadanie 29.2

Na podstawie samych wyników nie da się ocenić wszystkich kryteriów zakończenia testów, bo brakuje danych o defektach krytycznych i testach wysokiego priorytetu. Jeśli nie ma otwartych defektów krytycznych i wykonano wszystkie testy wysokiego priorytetu, to kryteria są spełnione.



Zadanie 29.3

Błędny status książki po zwrocie - ryzyko produktowe - działanie: poprawa działania i re-test.

Aplikacja nie uruchamia się na serwerze testowym - ryzyko projektowe - działanie: naprawa serwera i przygotowanie zapasowego środowiska.

Błędny termin wypożyczenia - ryzyko produktowe - działanie: poprawa obsługi dat i ponowne testy.



Zadanie 29.4

Na podstawie wyników nie zaleca się pełnego wdrożenia. 80 procent scenariuszy zakończyło się pozytywnie, ale są też scenariusze negatywne i zablokowane. Najlepsza będzie rekomendacja warunkowa po usunięciu błędów i wykonaniu brakujących testów.



LEKCJA 30



Zadanie 30.1

Sześć dokumentów testowych i ich zastosowanie:

1\. Plan testów - określa zakres, harmonogram, role i kryteria.

2\. Scenariusz testowy - opisuje, jak sprawdzić funkcjonalność.

3\. Lista kontrolna - pomaga sprawdzić kompletność działań.

4\. Rejestr ryzyk - zapisuje zagrożenia i działania zapobiegawcze.

5\. Raport błędów - zawiera defekty wykryte podczas testów.

6\. Raport testów - podsumowuje wyniki i pomaga podjąć decyzję.



Zadanie 30.2

Plan testów - gdy trzeba ustalić harmonogram i zakres.

Scenariusz testowy - gdy trzeba sprawdzić konkretną funkcję.

Lista kontrolna - gdy trzeba upewnić się, że wszystko zostało sprawdzone.

Rejestr ryzyk - gdy trzeba zapisać zagrożenia.

Raport błędów - gdy trzeba przekazać błędy programistom.

Raport testów - gdy trzeba podjąć decyzję o wdrożeniu.



Zadanie 30.3

Dokumentacja testowa jest częścią jakości produktu, bo pokazuje co było testowane, jakie były wyniki i jakie problemy wykryto. Dzięki temu można lepiej ocenić jakość aplikacji.



Zadanie 30.4

Mapa pojęć:

plan testów określa zasady

scenariusze i checklisty pomagają wykonać testy

rejestr ryzyk pokazuje zagrożenia

raport błędów zapisuje defekty

raport testów podsumowuje wyniki i daje rekomendację

