
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
        let shapeRule = this.getRule(shape);
        let oponentRule = this.getRule(oponent);
        if ((shapeRule instanceof ZSGameRule) && (oponentRule instanceof ZSGameRule)) {
            return this.getRule(shape).evaluateAgainst(oponent);
        }
        else {
            return Results.Error;
        }
    }
}