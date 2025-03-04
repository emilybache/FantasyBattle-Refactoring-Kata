import { Inventory } from '../src/Inventory';
import { Stats } from '../src/Stats';
import { SimpleEnemy } from '../src/SimpleEnemy';
import { Player } from '../src/Player';
import { Damage } from '../src/Damage';
import { BasicItem } from "../src/BasicItem";
import { SimpleArmor } from "../src/SimpleArmor";
import { BasicBuff } from "../src/BasicBuff";

// Helpful test data which corresponds to items listed in the top level README file
let shield: BasicItem = new BasicItem("round shield", 0, 1.4);
let sword: BasicItem = new BasicItem("Flashy sword of danger", 10, 1.0);
let excalibur: BasicItem = new BasicItem("Excalibur", 20, 1.5);
let helmet: BasicItem = new BasicItem("helmet of swiftness", 0, 1.2);
let boots: BasicItem = new BasicItem("ten league boots", 0, 0.1);
let breastplate: BasicItem = new BasicItem("breastplate of steel", 0, 1.4);
let enemy: SimpleEnemy = new SimpleEnemy(new SimpleArmor(5), [new BasicBuff(1.0, 1.0)]);


describe('Player', () => {

  // TODO: test is not finished!

  it('calculates damage', () => {
    const inventory = new Inventory(null!!);
    const stats = new Stats(0);
    const enemy = new SimpleEnemy(null!!, null!!);

    const damage: Damage = new Player(inventory, stats).calculateDamage(enemy);

    expect(damage.amount).toBe(10);
  });
})
