const Tie = "Tie";
const Win = "Win";
const Lose = "Lose";

class ZSGameService {
    constructor() {
        this.rules = {};
    }

    addRule(aRule) {
        aRule.parent = this;
        this.rules[aRule.id] = aRule;
        return this;
    }

    get length() {
        return Object.keys(this.rules).length;
    }

    getRule(indexOrId) {
        return this.rules[indexOrId];
    }

    evaluate(shape, oponent) {
        return this.getRule(shape).evaluateAgainst(oponent);
    }
}