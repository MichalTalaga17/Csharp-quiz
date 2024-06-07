using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace quiz
{
    public partial class MainWindow : Window
    {
        private int currentQuestionIndex = 0;
        private int score = 0;

        private readonly (string Question, string[] Options, string CorrectAnswer)[] quiz = new[]
        {
            (Question: "Jakie jest najwyższe pasmo górskie na świecie?", Options: new[] { "A. Himalaje", "B. Alpy", "C. Andy", "D. Kordyliery" }, CorrectAnswer: "A. Himalaje"),
            (Question: "Która rzeka jest najdłuższa na świecie?", Options: new[] { "A. Amazonka", "B. Nil", "C. Jangcy", "D. Missisipi" }, CorrectAnswer: "B. Nil"),
            (Question: "Jakie jest największe jezioro na świecie pod względem powierzchni?", Options: new[] { "A. Jezioro Michigan", "B. Jezioro Bajkał", "C. Morze Kaspijskie", "D. Jezioro Wiktorii" }, CorrectAnswer: "C. Morze Kaspijskie"),
            (Question: "Który kraj ma największą powierzchnię?", Options: new[] { "A. Kanada", "B. Rosja", "C. Chiny", "D. Stany Zjednoczone" }, CorrectAnswer: "B. Rosja"),
            (Question: "Jakie jest najmniejsze państwo na świecie?", Options: new[] { "A. Monako", "B. Watykan", "C. San Marino", "D. Liechtenstein" }, CorrectAnswer: "B. Watykan"),
            (Question: "Które miasto jest stolicą Australii?", Options: new[] { "A. Sydney", "B. Melbourne", "C. Canberra", "D. Perth" }, CorrectAnswer: "C. Canberra"),
            (Question: "Jakie jest najgłębsze miejsce na Ziemi?", Options: new[] { "A. Rów Mariański", "B. Rów Tonga", "C. Rów Filipiński", "D. Rów Kermadec" }, CorrectAnswer: "A. Rów Mariański"),
            (Question: "Która pustynia jest największa na świecie?", Options: new[] { "A. Sahara", "B. Gobi", "C. Kalahari", "D. Pustynia Arabijska" }, CorrectAnswer: "A. Sahara"),
            (Question: "Która wyspa jest największa na świecie?", Options: new[] { "A. Nowa Gwinea", "B. Borneo", "C. Madagaskar", "D. Grenlandia" }, CorrectAnswer: "D. Grenlandia"),
            (Question: "Które miasto jest największe pod względem liczby ludności?", Options: new[] { "A. Tokio", "B. Nowy Jork", "C. Szanghaj", "D. Meksyk" }, CorrectAnswer: "A. Tokio")
        };

        public MainWindow()
        {
            InitializeComponent();
            DisplayCurrentQuestion();
        }

        private void DisplayCurrentQuestion()
        {
            var question = quiz[currentQuestionIndex];
            txt_tresc.Content = question.Question;
            odp1.Content = question.Options[0];
            odp2.Content = question.Options[1];
            odp3.Content = question.Options[2];
            odp4.Content = question.Options[3];
            odp1.IsChecked = false;
            odp2.IsChecked = false;
            odp3.IsChecked = false;
            odp4.IsChecked = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedOption = new[] { odp1, odp2, odp3, odp4 }.FirstOrDefault(rb => rb.IsChecked == true);

            if (selectedOption == null)
            {
                MessageBox.Show("Proszę zaznaczyć odpowiedź przed przejściem do następnego pytania.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (selectedOption.Content.ToString() == quiz[currentQuestionIndex].CorrectAnswer)
            {
                score++;
            }

            currentQuestionIndex++;

            if (currentQuestionIndex < quiz.Length)
            {
                DisplayCurrentQuestion();
            }
            else
            {
                txt_tresc.Content = "Koniec quizu! Twój wynik: " + score + "/" + quiz.Length;
                odp1.Visibility = Visibility.Hidden;
                odp2.Visibility = Visibility.Hidden;
                odp3.Visibility = Visibility.Hidden;
                odp4.Visibility = Visibility.Hidden;
                btn_next.Visibility = Visibility.Hidden;
            }
        }
    }
}
