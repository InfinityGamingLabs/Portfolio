import 'package:flutter/material.dart';
import 'home_screen.dart';
import 'random_screen.dart';
import 'about.dart';

class MainNavigator extends StatelessWidget {
  const MainNavigator({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Navigator(
      onGenerateRoute: (settings) {
        late Widget page;

        switch (settings.name) {
          case '/':
            page = HomeScreen();
            break;
          case '/random':
            page = RandomScreen();
            break;
          case '/about':
            page = AboutPage();
            break;
          default:
            page = HomeScreen();
            break;
        }

        return MaterialPageRoute(
          settings: settings,
          builder: (BuildContext context) => page,
        );
      },
    );
  }
}
