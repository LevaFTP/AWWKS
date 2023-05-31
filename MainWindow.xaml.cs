using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Page[] pages;
        private int currentPageIndex;
        private bool[] myBools = new bool[30];

        public int BiA = 0;
        public int EiZ = 0;
        public int EAiI = 0;
        public int IPiL = 0;
        public int M = 0;
        public int WFiF = 0;

        public MainWindow()
        {
            InitializeComponent();
            pages = new Page[] {new Question_1(), new Question_2(), new Question_3(), new Question_4(), new Question_5(), new Question_6(), new Question_7(), new Question_8(), new Question_9(), new Question_10(), new Question_11(), new Question_12(), new Question_13(), new Question_14(), new Question_15(), new FinalPage(), new FinalPage2() };
            currentPageIndex = 0;
            MainFrame.Content = pages[currentPageIndex];
        }

        public void NavigateToNextPage()
        {
            if (currentPageIndex < pages.Length)
            {
                currentPageIndex++;
                MainFrame.Content = pages[currentPageIndex];
            }
        }


        public void ChangeToTrue(int index)
        {
            myBools[index] = true;
        }


        public void Result() 
        {
            for (int i = 0; i < myBools.Length; i++)
            {
                if (myBools[i])
                {
                    if (i == 0 || i == 6 || i == 12 || i == 18 || i == 24)
                    {
                        BiA++;
                    }
                    else if (i == 1 || i == 7 || i == 13 || i == 19 || i == 25)
                    {
                        EiZ++;
                    }
                    else if (i == 2 || i == 8 || i == 14 || i == 20 || i == 26)
                    {
                        EAiI++;
                    }
                    else if (i == 3 || i == 9 || i == 15 || i == 21 || i == 27)
                    {
                        IPiL++;
                    }
                    else if (i == 4 || i == 10 || i == 16 || i == 22 || i == 28)
                    {
                        M++;
                    }
                    else if (i == 5 || i == 11 || i == 17 || i == 23 || i == 29)
                    {
                        WFiF++;
                    }
                }
            }


        }

        public string BiAorEiz()
        {
            if (BiA > EiZ)
            {
                return ("Wydział Budownictwa i Architektury: \nskupia się na kształceniu studentów w dziedzinie budownictwa oraz architektury");
            }
            else
            {
                return ("Wydział Ekonomii i Zarządzania: \nskupia się na kształceniu studentów w dziedzinie ekonomii, zarządzania oraz administracji.");
            }
        }

        public string EAiIorIPiL()
        {
            if (EAiI > IPiL)
            {
                return ("Wydział Elektrotechniki, Automatyki i Informatyki: \nskupia się na kształceniu studentów w dziedzinie elektrotechniki, automatyki i informatyki oraz pokrewnych dziedzin.");
            }
            else
            {
                return ("Wydział Inżynierii Produkcji i Logistyki: \nskupia się na kształceniu studentów w dziedzinie inżynierii produkcji oraz logistyki, a także związanych z nimi specjalizacji.");
            }
        }
        public string MorWFiF()
        {
            if (M > WFiF)
            {
                return ("Wydział Mechaniczny: skupia się na kształceniu studentów w dziedzinie mechaniki i inżynierii mechanicznej, a także związanych z nią specjalizacji.");
            }
            else
            {
                return ("Wydział Wychowania Fizycznego i Fizjoterapii: skupia się na kształceniu studentów w dziedzinie wychowania fizycznego, sportu, turystyki i rekreacji, a także fizjoterapii.\r\n\r\n");
            }
        }



        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        public string BiAorEizdesc()
        {
            if (BiA > EiZ)
            {
                return 
                    ("Wydział Budownictwa i Architektury to część uczelni, która oferuje programy na poziomie studiów licencjackich, magisterskich i doktoranckich z zakresu budownictwa i architektury.\r\n\r\nKierunek Budownictwo skupia się na projektowaniu, budowaniu, konserwacji i utrzymaniu różnego rodzaju budynków i infrastruktury, takiej jak mosty, drogi, tunele, systemy wodno-kanalizacyjne oraz inne obiekty związane z przemysłem budowlanym. Studenci na tym kierunku zdobywają wiedzę z zakresu materiałoznawstwa, mechaniki budowli, hydrauliki, budownictwa drogowego, konstrukcji budowlanych, geotechniki i zarządzania projektami budowlanymi.\r\n\r\nKierunek Architektura skupia się na projektowaniu i planowaniu budynków i przestrzeni publicznych, takich jak budynki mieszkalne, biurowce, szkoły, szpitale, muzea, parki i place. Studenci na tym kierunku zdobywają wiedzę z zakresu teorii i historii architektury, projektowania, urbanistyki, technologii budowlanych, materiałów budowlanych, ochrony dziedzictwa kulturowego oraz zasad zrównoważonego rozwoju.\r\n\r\nOba kierunki wymagają od studentów dużej kreatywności, umiejętności technicznych i zdolności analitycznych. Absolwenci tych kierunków mają możliwość podjęcia pracy w sektorze budowlanym, architektonicznym i inżynieryjnym, a także mogą działać jako projektanci, inżynierowie, konsultanci, nauczyciele akademiccy lub badacze.");
            }
            else
            {
                return ("Wydział Ekonomii i Zarządzania to część uczelni, która oferuje programy na poziomie studiów licencjackich, magisterskich i doktoranckich z zakresu administracji, ekonomii i zarządzania.\r\n\r\nKierunek Administracja skupia się na nauce zasad zarządzania i funkcjonowania instytucji publicznych i prywatnych, takich jak szpitale, urzędy, przedsiębiorstwa, agencje rządowe i organizacje pozarządowe. Studenci na tym kierunku zdobywają wiedzę z zakresu zarządzania zasobami ludzkimi, prawa administracyjnego, finansów publicznych, planowania strategicznego, polityki publicznej i administracji elektronicznej.\r\n\r\nKierunek Ekonomia skupia się na badaniu procesów gospodarczych, takich jak produkcja, dystrybucja i konsumpcja dóbr i usług. Studenci na tym kierunku zdobywają wiedzę z zakresu teorii mikro- i makroekonomii, statystyki, rachunkowości, finansów, marketingu, ekonomii międzynarodowej i zarządzania ryzykiem.\r\n\r\nKierunek Zarządzanie skupia się na nauce zasad zarządzania w przedsiębiorstwach i organizacjach, takich jak planowanie strategiczne, zarządzanie projektami, analiza finansowa, zarządzanie zasobami ludzkimi, marketing, zarządzanie łańcuchem dostaw i logistyka. Studenci na tym kierunku zdobywają wiedzę z zakresu teorii zarządzania, ekonomii, psychologii organizacji, prawo pracy i zarządzanie innowacjami.");
            }
        }

        public string EAiIorIPiLdesc()
        {
            if (EAiI > IPiL)
            {
                return ("Wydział Elektrotechniki, Automatyki i Informatyki oferuje różnorodne kierunki studiów związane z elektrotechniką, automatyką, robotyką, informatyką oraz inżynierią biomedyczną i technologiami energetyki odnawialnej.\r\n\r\nAutomatyka i Robotyka - kierunek związany z projektowaniem, budową, programowaniem i obsługą robotów przemysłowych i mobilnych, a także z automatyzacją procesów produkcyjnych w różnych gałęziach przemysłu.\r\nElektronika przemysłowa - kierunek skupiający się na projektowaniu i wdrażaniu elektronicznych urządzeń sterujących i pomiarowych w przemyśle.\r\nElektronika i systemy komputerowe - kierunek łączący wiedzę z dziedziny elektroniki i informatyki, umożliwiający projektowanie i implementację zaawansowanych systemów elektronicznych i komputerowych.\r\nElektrotechnika - kierunek skupiający się na projektowaniu, budowie i eksploatacji różnego rodzaju systemów elektrycznych, w tym zasilania, oświetlenia, automatyki budynkowej i przemysłowej.\r\nInformatyka - kierunek skupiający się na programowaniu, projektowaniu systemów informatycznych, analizie danych, sztucznej inteligencji i innych dziedzinach związanych z informatyką.\r\nComputer Engineering - kierunek skupiający się na projektowaniu i budowie sprzętu komputerowego oraz na jego integracji z oprogramowaniem.\r\nInżynieria Biomedyczna - kierunek skupiający się na projektowaniu, budowie i wdrażaniu zaawansowanych systemów medycznych, takich jak urządzenia do diagnozowania, monitorowania i terapii pacjentów.\r\nTechnologie Energetyki Odnawialnej - kierunek skupiający się na projektowaniu, budowie i wdrażaniu systemów związanych z wykorzystaniem źródeł energii odnawialnej, takich jak energia słoneczna, wiatrowa, geotermalna czy biomasa.");
            }
            else
            {
                return ("Wydział Inżynierii Produkcji i Logistyki oferuje różnorodne kierunki studiów związane z produkcją, logistyką oraz żywnością i żywieniem człowieka. Poniżej znajduje się krótki opis każdego z tych kierunków:\r\n\r\nDietetyka i jakość żywności - kierunek skupiający się na zdrowym odżywianiu i analizie składu żywności, a także na projektowaniu i nadzorowaniu procesów produkcji żywności o wysokiej jakości.\r\n\r\nInżynieria bezpieczeństwa - kierunek skupiający się na projektowaniu i wdrażaniu systemów związanych z zapobieganiem zagrożeniom w miejscu pracy oraz zminimalizowaniu skutków wypadków i awarii.\r\n\r\nLogistyka - kierunek skupiający się na projektowaniu, planowaniu i zarządzaniu procesami transportowymi oraz dystrybucyjnymi w różnych gałęziach przemysłu i handlu.\r\n\r\nTechnologia żywności i żywienie człowieka - kierunek skupiający się na projektowaniu i wdrażaniu procesów produkcji żywności oraz na analizie składu i właściwości żywności, a także na badaniu wpływu diety na zdrowie człowieka.\r\n\r\nZarządzanie i inżynieria produkcji - kierunek skupiający się na projektowaniu, organizowaniu i zarządzaniu procesami produkcyjnymi, w tym na analizie kosztów produkcji, optymalizacji procesów i doskonaleniu jakości produktów.");
            }
        }
        public string MorWFiFdesc()
        {
            if (M > WFiF)
            {
                return ("Wydział Mechaniczny oferuje szereg kierunków studiów związanych z mechaniką, lotnictwem, wzornictwem przemysłowym, mechatroniką, energetyką i inżynierią środowiska. Poniżej znajduje się krótki opis każdego z tych kierunków:\r\n\r\nEnergetyka i inżynieria środowiska - kierunek skupiający się na projektowaniu i wdrażaniu rozwiązań związanych z ochroną środowiska oraz na projektowaniu, analizie i optymalizacji systemów energetycznych.\r\n\r\nWzornictwo przemysłowe - kierunek skupiający się na projektowaniu przedmiotów użytkowych, ich funkcjonalności, ergonomii, estetyki i produkcji seryjnej.\r\n\r\nMechatronika - kierunek skupiający się na projektowaniu i wdrażaniu systemów złożonych z mechaniki, elektroniki i informatyki, np. robotów przemysłowych, automatyki procesów technologicznych, systemów transportowych.\r\n\r\nMechanika i Budowa Maszyn - kierunek skupiający się na projektowaniu, budowie i eksploatacji maszyn i urządzeń, a także na analizie ich wytrzymałościowej, dynamiki i kinematyki.");
            }
            else
            {
                return ("Wydział Wychowania Fizycznego i Fizjoterapii oferuje kierunki studiów związane ze zdrowiem, rekreacją, sportem oraz bezpieczeństwem. Poniżej znajduje się krótki opis każdego z tych kierunków:\r\n\r\nSport i Bezpieczeństwo - kierunek skupiający się na projektowaniu, wdrażaniu i ocenie programów i działań związanych z bezpieczeństwem w sporcie, a także na analizie psychologicznej i pedagogicznej sportowców.\r\n\r\nTurystyka i Rekreacja - kierunek skupiający się na projektowaniu, organizowaniu i zarządzaniu programami i usługami związanymi z turystyką i rekreacją, a także na analizie rynku turystycznego i potrzeb klientów.\r\n\r\nWychowanie Fizyczne - kierunek skupiający się na nauczaniu i wychowaniu dzieci i młodzieży w zakresie ruchu i sportu, a także na prowadzeniu badań nad wpływem aktywności fizycznej na zdrowie i rozwój człowieka.\r\n\r\nStudenci na tych kierunkach mogą zdobyć wiedzę i umiejętności potrzebne do pracy w dziedzinach związanych z kulturą fizyczną, sportem, turystyką, rekreacją, zdrowiem oraz edukacją fizyczną i ruchową.");
            }
        }

    }
}
