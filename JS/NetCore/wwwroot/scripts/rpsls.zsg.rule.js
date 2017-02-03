class ZSGameRule {
    constructor(id, gameSvc) {
        this.id = id;
        this.parent = gameSvc;
        this.defeats = [];
    }

    wins(anOponent) {
        this.defeats.push(this.getName(anOponent));
        return this;
    }

    loses(anOponent) {
        var oponentRule = this.parent.getRuleFor(anOponent) || this.parent.addRuleFor(anOponent);
        oponentRule.wins(this.id);
        return this;
    }

    evaluateAgainst(anOponent) {
        if (this.id === anOponent) return Tie;
        return this.defeats.includes(anOponent) ? Win : Lose;
    }

    getName(anOponent) {
        if (typeof (anOponent) === "object") {
            if (anOponent.hasOwnProperty("id")) {
                return anOponent.id;
            }
            else {
                return anOponent.toString();
            }
        }
        return anOponent;
    }
};
