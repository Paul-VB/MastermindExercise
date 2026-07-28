using Mastermind;

var RandomAnswerGenerator = new RandomAnswerGenerator();
var GuessChecker= new GuessChecker();

var Game = new Game(RandomAnswerGenerator, GuessChecker);
Game.Run();
