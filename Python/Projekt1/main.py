from random import randint
from random import \
    uniform
from math import exp
import \
    matplotlib.pyplot as plt
from matplotlib.lines import \
    Line2D

ROZMIAR_OGRODU = int(input("PODAJ ROZMIAR OGRODU: "))
LICZBA_ITERACJI = int(input("PODAJ ILOŚĆ ITERACJI: "))

PLIK_MYSZY = "myszy.txt"
PLIK_KOTY_PRZECIETNIAKI = "kotyPrzecietniaki.txt"
PLIK_KOTY_LENIUCHY = "kotyLeniuchy.txt"
PLIK_KOTY_KOCIAKI = "kotyKociaki.txt"

tabMYSZY = []
tabKOTY = []


def odleglosc(x1, y1, x2, y2):

    return ((((x2 - x1) ** 2) + ((y2 - y1) ** 2)) ** 0.5)


class Mysz:

    def __init__(self, x, y):
        '''
        Konstruktor klasy Mysz.
        '''
        self.sciezka = []
        self.krok = 1
        self.x = x
        self.y = y
        self.kolor = 'c'
        self.sciezka.append((self.x, self.y))

    def zrobKrok(self):
        '''
        Funkcja przesuwająca Mysz po ogrodzie.
        '''
        self.x = self.x + (randint(-self.krok, self.krok))
        self.y = self.y + (randint(-self.krok, self.krok))
        self.sciezka.append((self.x, self.y))
        self.sprawdzPozycje()
        self.sprawdzSpotkania()

    def sprawdzPozycje(self):
        '''
        Funkcja sprawdzająca poprawność położenia Myszy.
        '''
        if ((self.x < 0 or self.x > ROZMIAR_OGRODU) or (self.y < 0 or self.y > ROZMIAR_OGRODU)):
            self.x = self.sciezka[len(self.sciezka) - 2][0]
            self.y = self.sciezka[len(self.sciezka) - 2][1]
            self.sciezka.append((self.x, self.y))

    def sprawdzSpotkania(self):
        '''
        Funkcja sprawdzająca czy Mysz spotkała Kota.
        '''
        for kot in tabKOTY:
            if (odleglosc(self.x, self.y, kot.x, kot.y) < 4):
                if (kot.typ == "Przecietniak"):
                    self.x = self.sciezka[0][0]
                    self.y = self.sciezka[0][1]
                    self.sciezka.append((self.x, self.y))
                elif (kot.typ == "Leniuch"):
                    if (uniform(0, 1) < (1 / (1 + (exp(-0.1 * kot.przegonioneMyszy))))):
                        kot.przegonioneMyszy += 1
                        self.x = self.sciezka[0][0]
                        self.y = self.sciezka[0][1]
                        self.sciezka.append((self.x, self.y))
                elif (kot.typ == "Kociak"):
                    if (odleglosc(kot.x, kot.y, kot.sciezka[0][0], kot.sciezka[0][1]) <= 50):
                        self.x = self.sciezka[0][0]
                        self.y = self.sciezka[0][1]
                        self.sciezka.append((self.x, self.y))
                    else:
                        kot.x = kot.sciezka[0][0]
                        kot.y = kot.sciezka[0][1]
                        kot.sciezka.append((kot.x, kot.y))


class Kot:

    def __init__(self, x, y):
        '''
        Konstruktor klasy Kot.
        '''
        self.sciezka = []
        self.krok = None
        self.x = x
        self.y = y
        self.typ = None
        self.kolor = None
        self.sciezka.append((self.x, self.y))

    def zrobKrok(self):
        '''
        Funkcja przesuwająca Kota po ogrodzie.
        '''
        self.x = self.x + (randint(-self.krok, self.krok))
        self.y = self.y + (randint(-self.krok, self.krok))
        self.sciezka.append((self.x, self.y))
        self.sprawdzPozycje()

    def sprawdzPozycje(self):
        '''
        Funkcja sprawdzająca poprawność położenia Kota.
        '''
        if ((self.x < 0 or self.x > ROZMIAR_OGRODU) or (self.y < 0 or self.y > ROZMIAR_OGRODU)):
            self.x = self.sciezka[len(self.sciezka) - 2][0]
            self.y = self.sciezka[len(self.sciezka) - 2][1]
            self.sciezka.append((self.x, self.y))


class KotPrzecietniak(Kot):
    '''
    Klasa KotPrzecietniak jest rodzajem klasy Kot.
    '''

    def __init__(self, x, y):
        '''
        Konstruktor klasy KotPrzecietniak.
        - Ustawiamy kolor ścieżki Kota Przeciętniaka na 'r' (czerwony)
        '''
        super().__init__(x, y)
        self.krok = 10
        self.typ = "Przecietniak"
        self.kolor = 'r'


class KotLeniuch(Kot):
    '''
    Klasa KotLeniuch jest rodzajem klasy Kot.
    '''

    def __init__(self, x, y):
        '''
        Konstruktor klasy KotLeniuch.
        - Ustawiamy kolor ścieżki Kota Leniucha na 'b' (niebieski)
        '''
        super().__init__(x, y)
        self.krok = 10
        self.typ = "Leniuch"
        self.kolor = 'b'
        self.przegonioneMyszy = 0


class KotKociak(Kot):
    '''
    Klasa KotKociak jest rodzajem klasy Kot.
    '''

    def __init__(self, x, y):
        '''
        Konstruktor klasy KotKociak.
        - Ustawiamy kolor ścieżki Kota Kociaka na 'g' (zielony)
        - Deklarujemy zmienną "ucieczki" Kota Kociaka, przechowującą ilość jego ucieczek
        przed Myszami
        '''
        super().__init__(x, y)
        self.krok = 5
        self.typ = "Kociak"
        self.kolor = 'g'

    def sprawdzPozycje(self):
        '''
        Funkcja sprawdzająca poprawność położenia Kota Kociaka.
        '''
        if ((self.x < 0 or self.x > ROZMIAR_OGRODU) or (self.y < 0 or self.y > ROZMIAR_OGRODU)
                or (odleglosc(self.x, self.y, self.sciezka[0][0], self.sciezka[0][1]) > 100)):
            self.x = self.sciezka[len(self.sciezka) - 2][0]
            self.y = self.sciezka[len(self.sciezka) - 2][1]
            self.sciezka.append((self.x, self.y))


def wczytajZwierzeta():
    '''
    Zmienna wczytująca początkowe pozycje zwierząt z plików do tablic MYSZY oraz KOTY.
    '''

    def wczytajMyszy():
        linie = open('myszy.txt', 'r').readlines()
        for linia in linie:
            xy = linia.split()
            tabMYSZY.append(Mysz(int(xy[0]), int(xy[1])))

    def wczytajKotyPrzecietniaki():
        linie = open('kotyPrzecietniaki.txt', 'r').readlines()
        for linia in linie:
            xy = linia.split()
            tabKOTY.append(KotPrzecietniak(int(xy[0]), int(xy[1])))

    def wczytajKotyLeniuchy():
        linie = open('kotyLeniuchy.txt', 'r').readlines()
        for linia in linie:
            xy = linia.split()
            tabKOTY.append(KotLeniuch(int(xy[0]), int(xy[1])))

    def wczytajKotyKociaki():
        linie = open('kotyKociaki.txt', 'r').readlines()
        for linia in linie:
            xy = linia.split()
            tabKOTY.append(KotKociak(int(xy[0]), int(xy[1])))

    wczytajKotyPrzecietniaki()
    wczytajKotyLeniuchy()
    wczytajKotyKociaki()
    wczytajMyszy()


def wykonajIteracje():
    '''
    Funkcja wykonująca iteracje (ruchy zwierząt w Ogrodzie).
    '''
    for i in range(LICZBA_ITERACJI):
        for kot in tabKOTY:
            kot.zrobKrok()
        for mysz in tabMYSZY:
            mysz.zrobKrok()


def wyswietlSciezki():
    '''
    Funkcja wyświetlająca wykres (ścieżki zwierząt).
    '''

    for kot in tabKOTY:
        plt.plot(*zip(kot.sciezka[0]), 'k',
                 marker="s")
        plt.plot(*zip(*kot.sciezka), kot.kolor,
                 alpha=0.7)

    for mysz in tabMYSZY:
        plt.plot(*zip(mysz.sciezka[0]), 'k', marker="o")
        plt.plot(*zip(*mysz.sciezka), mysz.kolor,
                 alpha=0.7)

    plt.rcParams["figure.figsize"] = (10, 10)

    plt.title("MYSZY I KOTY W OGRODZIE")
    plt.show()


def wyczyscZwierzeta():
    '''
    W przypadku, gdybyśmy chcieli wyczyścić Ogród, czyli rozpocząć symulację
    od nowa, należy wyczyścić tablice przechowujące Myszy i Koty.
    '''
    tabMYSZY.clear()
    tabKOTY.clear()


wczytajZwierzeta()
wykonajIteracje()
wyswietlSciezki()

wyczyscZwierzeta()