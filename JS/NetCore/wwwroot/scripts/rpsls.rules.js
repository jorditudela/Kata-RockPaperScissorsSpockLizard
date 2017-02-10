/* requires rpsls.shapes rpsls.zgs.rule */

class RockRule extends ZSGameRule {
    constructor() {
        super(Shapes.rock);
    }

    crushes(oponentTarget) {
        return this.wins(oponentTarget);
    }
}

class PaperRule extends ZSGameRule {
    constructor() {
        super(Shapes.paper);
    }

    covers(oponentTarget) {
        return this.wins(oponentTarget);
    };

    disproves(oponentTarget) {
        return this.wins(oponentTarget);
    }
}

class ScissorsRule extends ZSGameRule {
    constructor() {
        super(Shapes.scissors);
    }

    cuts(oponentTarget) {
        return this.wins(oponentTarget);
    }

    decapitates(oponentTarget) {
        return this.wins(oponentTarget);
    }
}

class LizardRule extends ZSGameRule {
    constructor() {
        super(Shapes.lizard);
    }

    poisons(oponentTarget) {
        return this.wins(oponentTarget);
    }

    eats(oponentTarget) {
        return this.wins(oponentTarget);
    }
}

class SpockRule extends ZSGameRule {
    constructor() {
        super(Shapes.spock);
    }

    smashes(oponentTarget) {
        return this.wins(oponentTarget);
    }

    vaporizes(oponentTarget) {
        return this.wins(oponentTarget);
    }
}

const Rock = new RockRule();
const Paper = new PaperRule();
const Scissors = new ScissorsRule();
const Lizard = new LizardRule();
const Spock = new SpockRule();
