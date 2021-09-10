using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScrollViewBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await AddViews();
        }

        private async Task AddViews()
        {
            await System.Threading.Tasks.Task.Delay(3000);

            var stackLayoutForHorizontalSrollView = new StackLayout();
            stackLayoutForHorizontalSrollView.BackgroundColor = Color.Yellow;
            stackLayoutForHorizontalSrollView.Children.Add(new Label() { MaxLines = 1, Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ultrices, sapien sed accumsan condimentum, tellus nisi porta nibh, sit amet laoreet diam velit vitae lacus. Nulla odio leo, tincidunt ut tellus id, eleifend suscipit enim. Quisque mattis venenatis consequat. Ut at sapien cursus, tempor sem ac, gravida magna. Nunc ac orci nec est pellentesque auctor et id purus. Nullam finibus justo enim, ac accumsan erat varius in. Vestibulum ac sollicitudin lorem. Etiam ornare, ante et condimentum eleifend, justo felis commodo neque, ac bibendum urna libero a est." });
            stackLayoutForHorizontalSrollView.Children.Add(new Label() { MaxLines = 1, Text = "Sed rutrum urna urna, at feugiat mi euismod non. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla facilisi. Integer at odio in augue tincidunt fermentum semper id tortor. Curabitur tincidunt maximus ultrices. Quisque tristique diam et dignissim lobortis. Nulla feugiat, sem vitae varius posuere, enim libero luctus eros, eu gravida neque ante id mauris. Pellentesque ac interdum neque. Sed eleifend dapibus nunc sed condimentum. Vestibulum tempor metus at sem imperdiet, malesuada sollicitudin urna pulvinar. Donec lobortis viverra aliquet." });
            stackLayoutForHorizontalSrollView.Children.Add(new Label() { MaxLines = 1, Text = "Suspendisse auctor, nunc sit amet imperdiet tempus, mi lorem mattis nisi, at tincidunt est nisi vel justo. Duis sollicitudin velit molestie purus ullamcorper ultricies. Fusce lectus felis, ullamcorper eget nulla id, dictum vestibulum lorem. Nunc vel neque consectetur, dictum arcu non, aliquet turpis. In sit amet sodales ex. Aliquam vulputate maximus augue, a aliquet nulla tristique porta. Ut venenatis varius tellus non maximus. Praesent non lectus nibh. Etiam rhoncus turpis neque, id molestie libero lacinia at. In at eros urna. Nunc vitae ipsum mollis felis auctor imperdiet vel nec ipsum. Morbi auctor ligula in sem placerat, fringilla commodo odio imperdiet. Pellentesque nec orci vel massa accumsan lacinia. Proin sit amet ipsum ut leo lobortis ultricies sit amet nec nibh." });
            stackLayoutForHorizontalSrollView.Children.Add(new Label() { MaxLines = 1, Text = "Proin fringilla, enim placerat gravida rhoncus, diam orci pharetra magna, id placerat turpis quam at odio. Donec elit lorem, rutrum sit amet sagittis in, consequat ut nisi. Maecenas magna turpis, efficitur sit amet convallis vitae, dignissim nec tortor. Quisque vehicula dui a sapien convallis, in laoreet enim vehicula. Praesent sed sodales nibh, quis vulputate nisi. Integer id lectus bibendum, sodales erat ac, convallis ante. Nam placerat ex vitae metus elementum aliquet. Fusce at neque vulputate, lacinia ipsum vitae, commodo lacus." });
            stackLayoutForHorizontalSrollView.Children.Add(new Label() { MaxLines = 1, Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus ultrices, sapien sed accumsan condimentum, tellus nisi porta nibh, sit amet laoreet diam velit vitae lacus. Nulla odio leo, tincidunt ut tellus id, eleifend suscipit enim. Quisque mattis venenatis consequat. Ut at sapien cursus, tempor sem ac, gravida magna. Nunc ac orci nec est pellentesque auctor et id purus. Nullam finibus justo enim, ac accumsan erat varius in. Vestibulum ac sollicitudin lorem. Etiam ornare, ante et condimentum eleifend, justo felis commodo neque, ac bibendum urna libero a est." });
            stackLayoutForHorizontalSrollView.Children.Add(new Label() { MaxLines = 1, Text = "Sed rutrum urna urna, at feugiat mi euismod non. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Nulla facilisi. Integer at odio in augue tincidunt fermentum semper id tortor. Curabitur tincidunt maximus ultrices. Quisque tristique diam et dignissim lobortis. Nulla feugiat, sem vitae varius posuere, enim libero luctus eros, eu gravida neque ante id mauris. Pellentesque ac interdum neque. Sed eleifend dapibus nunc sed condimentum. Vestibulum tempor metus at sem imperdiet, malesuada sollicitudin urna pulvinar. Donec lobortis viverra aliquet." });
            stackLayoutForHorizontalSrollView.Children.Add(new Label() { MaxLines = 1, Text = "Suspendisse auctor, nunc sit amet imperdiet tempus, mi lorem mattis nisi, at tincidunt est nisi vel justo. Duis sollicitudin velit molestie purus ullamcorper ultricies. Fusce lectus felis, ullamcorper eget nulla id, dictum vestibulum lorem. Nunc vel neque consectetur, dictum arcu non, aliquet turpis. In sit amet sodales ex. Aliquam vulputate maximus augue, a aliquet nulla tristique porta. Ut venenatis varius tellus non maximus. Praesent non lectus nibh. Etiam rhoncus turpis neque, id molestie libero lacinia at. In at eros urna. Nunc vitae ipsum mollis felis auctor imperdiet vel nec ipsum. Morbi auctor ligula in sem placerat, fringilla commodo odio imperdiet. Pellentesque nec orci vel massa accumsan lacinia. Proin sit amet ipsum ut leo lobortis ultricies sit amet nec nibh." });
            stackLayoutForHorizontalSrollView.Children.Add(new Label() { MaxLines = 1, Text = "Proin fringilla, enim placerat gravida rhoncus, diam orci pharetra magna, id placerat turpis quam at odio. Donec elit lorem, rutrum sit amet sagittis in, consequat ut nisi. Maecenas magna turpis, efficitur sit amet convallis vitae, dignissim nec tortor. Quisque vehicula dui a sapien convallis, in laoreet enim vehicula. Praesent sed sodales nibh, quis vulputate nisi. Integer id lectus bibendum, sodales erat ac, convallis ante. Nam placerat ex vitae metus elementum aliquet. Fusce at neque vulputate, lacinia ipsum vitae, commodo lacus." });

            var horizontalSrollView = new ScrollView()
            {
                BackgroundColor = Color.Red,
                Content = new ContentView() { Content = stackLayoutForHorizontalSrollView },
                Orientation = ScrollOrientation.Horizontal
            };

            var mainStackView = new StackLayout()
            {
                Spacing = 20
            };

            mainStackView.Children.Add(horizontalSrollView);

            Content = new ScrollView() { Content = mainStackView };

            ActivityIndicator activityIndicator = new ActivityIndicator() { IsRunning = true};
            mainStackView.Children.Add(activityIndicator);
            await System.Threading.Tasks.Task.Delay(3000);
            mainStackView.Children.Remove(activityIndicator);

            mainStackView.Children.Add(new Label() { Text = "Label1" });
            mainStackView.Children.Add(new Label() { Text = "Label2" });
            mainStackView.Children.Add(new Label() { Text = "Label3" });
            mainStackView.Children.Add(new Label() { Text = "Label4" });
            mainStackView.Children.Add(new Label() { Text = "Label5" });
            mainStackView.Children.Add(new Label() { Text = "Label6" });
            mainStackView.Children.Add(new Label() { Text = "Label7" });
            mainStackView.Children.Add(new Label() { Text = "Label8" });
            mainStackView.Children.Add(new Label() { Text = "Label9" });
            mainStackView.Children.Add(new Label() { Text = "Label10" });
            mainStackView.Children.Add(new Label() { Text = "Label11" });
            mainStackView.Children.Add(new Label() { Text = "Label12" });
            mainStackView.Children.Add(new Label() { Text = "Label13" });
            mainStackView.Children.Add(new Label() { Text = "Label14" });
            mainStackView.Children.Add(new Label() { Text = "Label15" });
            mainStackView.Children.Add(new Label() { Text = "Label16" });
            mainStackView.Children.Add(new Label() { Text = "Label17" });
            mainStackView.Children.Add(new Label() { Text = "Label18" });
            mainStackView.Children.Add(new Label() { Text = "Label19" });
            mainStackView.Children.Add(new Label() { Text = "Label20" });
            mainStackView.Children.Add(new Label() { Text = "Label21" });
            mainStackView.Children.Add(new Label() { Text = "Label22" });
            mainStackView.Children.Add(new Label() { Text = "Label23" });
            mainStackView.Children.Add(new Label() { Text = "Label24" });
            mainStackView.Children.Add(new Label() { Text = "Label25" });
            mainStackView.Children.Add(new Label() { Text = "Label26" });
            mainStackView.Children.Add(new Label() { Text = "Label27" });
            mainStackView.Children.Add(new Label() { Text = "Label28" });
            mainStackView.Children.Add(new Label() { Text = "Label29" });
            mainStackView.Children.Add(new Label() { Text = "Label30" });

            mainStackView.Children.Add(new Editor());
        }
    }
}
