using CyberSecurityBotGUI.Models;
using CyberSecurityBotGUI.Services;
using CyberSecurityBotGUI.Utils;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfAnimatedGif;
using System.Windows.Media.Effects;


namespace CyberSecurityBotGUI
{
    public partial class MainWindow : Window
    {


        private ChatbotService chatbot;

        public MainWindow()
        {




            InitializeComponent();
            ApplyDefaultTheme();

            chatbot = new ChatbotService();

AddAsciiMessage(
@" ██████╗██╗   ██╗██████╗ ███████╗██████╗
██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝
██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
╚██████╗   ██║   ██████╔╝███████╗██║  ██║
 ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝");
            AddBotMessage(
                "Hello! I'm here to help you stay safe online.");

            AddBotMessage(
                "Ask me about passwords, phishing, scams, or privacy.");


        }

        private async void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string userMessage = UserInput.Text.Trim();

            // This is the Input space
            if (string.IsNullOrWhiteSpace(userMessage))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            
            AddUserMessage(userMessage);

            UserInput.Clear();

            await Task.Delay(1200);
        
            ResponseHandler handler = chatbot.GetResponse;

            string botResponse = handler(userMessage);
        
            AddBotMessage(botResponse);
            
            ScrollChatToBottom();


        }
     

        private void UserInput_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

            if (e.Key == System.Windows.Input.Key.Enter)
            {
                SendButton_Click(sender, e);
            }
        }
        private void Friday_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var image = new BitmapImage();

            ApplyOrangeTheme();

            image.BeginInit();
            image.UriSource = new Uri("Assets/friday.gif", UriKind.Relative);
            image.EndInit();

            ImageBehavior.SetAnimatedSource(ChatBackground, image);
        }

        private void Jarvis_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var image = new BitmapImage();

            ApplyRedTheme();

            image.BeginInit();
            image.UriSource = new Uri("Assets/Jarvis.gif", UriKind.Relative);
            image.EndInit();

            ImageBehavior.SetAnimatedSource(ChatBackground, image);
        }

        private void Ultron_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var image = new BitmapImage();

            

            image.BeginInit();
            image.UriSource = new Uri("Assets/Ultron.gif", UriKind.Relative);
            image.EndInit();

            ImageBehavior.SetAnimatedSource(ChatBackground, image);
        }

        // this next code is for changing my background for like the different UI AGENTS
        private void ApplyDefaultTheme()
        {
            MainWindowUI.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0F1115"));

            SidebarPanel.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1A1D24"));

            TopHeader.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1A1D24"));

            InputPanel.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1A1D24"));

            PasswordCard.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2A2F3A"));

            PhishingCard.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2A2F3A"));

            PrivacyCard.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2A2F3A"));

            SendBtn.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#6B7280"));

            UserInput.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2A2F3A"));
        }
        // ORANGEEEEEEEEEEEEE
        private void ApplyOrangeTheme()
        {
            MainWindowUI.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1A120B"));

            SidebarPanel.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2B1B12"));

            TopHeader.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2B1B12"));

            ChatPanel.Background = Brushes.Transparent;


            InputPanel.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2B1B12"));

            PasswordCard.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B2A1F"));

            PhishingCard.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B2A1F"));

            PrivacyCard.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B2A1F"));

            SendBtn.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EA580C"));

            UserInput.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B2A1F"));
        }
        //REDDDDDDDDDDDDDDD
        private void ApplyRedTheme()
        {
            MainWindowUI.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#140B0B"));

            SidebarPanel.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2A1111"));

            TopHeader.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2A1111"));


            ChatPanel.Background = Brushes.Transparent;


            InputPanel.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2A1111"));

            PasswordCard.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3A1A1A"));

            PhishingCard.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3A1A1A"));

            PrivacyCard.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3A1A1A"));

            SendBtn.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DC2626"));

            UserInput.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3A1A1A"));
        }

        //BLUEEEEEEEEE
        private void ApplyUltronTheme()
        {
            MainWindowUI.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0B0F19"));

            SidebarPanel.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#111827"));

            TopHeader.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#111827"));



            ChatPanel.Background = Brushes.Transparent;


            InputPanel.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#111827"));

            PasswordCard.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1F2937"));

            PhishingCard.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1F2937"));

            PrivacyCard.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1F2937"));

            SendBtn.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2563EB"));

            UserInput.Background =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1F2937"));
        }

        private void AddBotMessage(string message)
        {
            Border bubble = new Border
            {
                Background = new SolidColorBrush(
                    (Color)ColorConverter.ConvertFromString("#1E293B")),

                CornerRadius = new CornerRadius(18),

                Padding = new Thickness(15),

                Margin = new Thickness(10),

                MaxWidth = 520,

                HorizontalAlignment = HorizontalAlignment.Left,

                Effect = new System.Windows.Media.Effects.DropShadowEffect
                {
                    Color = Colors.Cyan,
                    BlurRadius = 20,
                    ShadowDepth = 0,
                    Opacity = 0.8
                }
            };

            StackPanel stack = new StackPanel();

            TextBlock botName = new TextBlock
            {
                Text = "🤖 CYBER BOT",
                Foreground = Brushes.Cyan,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 8),
                FontSize = 13
            };

            TextBlock text = new TextBlock
            {
                Text = message,
                Foreground = Brushes.White,
                FontSize = 15,
                TextWrapping = TextWrapping.Wrap
            };

            stack.Children.Add(botName);
            stack.Children.Add(text);

            bubble.Child = stack;

            ChatMessages.Children.Add(bubble);
        }
        private void AddAsciiMessage(string ascii)
        {
            Border bubble = new Border
            {
                Background = new SolidColorBrush(
                    (Color)ColorConverter.ConvertFromString("#111827")),

                CornerRadius = new CornerRadius(18),

                Padding = new Thickness(20),

                Margin = new Thickness(10),

                HorizontalAlignment = HorizontalAlignment.Left,

                Effect = new System.Windows.Media.Effects.DropShadowEffect
                {
                    Color = Colors.Cyan,
                    BlurRadius = 25,
                    ShadowDepth = 0,
                    Opacity = 0.9
                }
            };

            TextBlock text = new TextBlock
            {
                Text = ascii,
                Foreground = Brushes.Cyan,
                FontFamily = new FontFamily("Consolas"),
                FontSize = 14,
                TextWrapping = TextWrapping.NoWrap
            };

            bubble.Child = text;

            ChatMessages.Children.Add(bubble);
        }

        private void AddUserMessage(string message)
        {
            Border bubble = new Border
            {
                Background = new SolidColorBrush(
                    (Color)ColorConverter.ConvertFromString("#374151")),

                CornerRadius = new CornerRadius(18),

                Padding = new Thickness(15),

                Margin = new Thickness(10),

                MaxWidth = 520,

                HorizontalAlignment = HorizontalAlignment.Right,

                Effect = new System.Windows.Media.Effects.DropShadowEffect
                {
                    Color = Colors.DeepSkyBlue,
                    BlurRadius = 15,
                    ShadowDepth = 0,
                    Opacity = 0.6
                }
            };

            StackPanel stack = new StackPanel();

            TextBlock userName = new TextBlock
            {
                Text = "👤 YOU",
                Foreground = Brushes.LightBlue,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 0, 0, 8),
                FontSize = 13,
                TextAlignment = TextAlignment.Right
            };

            TextBlock text = new TextBlock
            {
                Text = message,
                Foreground = Brushes.White,
                FontSize = 15,
                TextWrapping = TextWrapping.Wrap,
                TextAlignment = TextAlignment.Right
            };

            stack.Children.Add(userName);
            stack.Children.Add(text);

            bubble.Child = stack;

            ChatMessages.Children.Add(bubble);
        }

        private void ScrollChatToBottom()
        {
            if (VisualTreeHelper.GetChildrenCount(ChatMessages) > 0)
            {
                FrameworkElement element =
                    (FrameworkElement)ChatMessages.Children[
                        ChatMessages.Children.Count - 1];

                element.BringIntoView();
            }
        }
    }
}