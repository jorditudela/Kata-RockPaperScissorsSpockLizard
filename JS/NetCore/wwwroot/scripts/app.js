/* requires rpsls.zsg.service rpsls.rules */
var Game = new ZSGameService();
Game
    .addRule(Scissors.cuts(Paper))
    .addRule(Paper.covers(Rock))
    .addRule(Rock.crushes(Lizard))
    .addRule(Lizard.poisons(Spock))
    .addRule(Spock.smashes(Scissors))
    .addRule(Scissors.decapitates(Lizard))
    .addRule(Lizard.eats(Paper))
    .addRule(Paper.disproves(Spock))
    .addRule(Spock.vaporizes(Rock))
    .addRule(Rock.crushes(Scissors));