package codingdojo;

import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.mockito.Mockito.mock;

public class PlayerTest {

    /*
     * Helpful test data which corresponds to items listed in the top level README file
     */
    public static class TestData
    {
        public static BasicItem shield = new BasicItem("round shield", 0, 1.4f);
        public static BasicItem sword = new BasicItem("Flashy sword of danger", 10, 1.0f);
        public static BasicItem excalibur = new BasicItem("Excalibur", 20, 1.5f);
        public static BasicItem helmet = new BasicItem("helmet of swiftness", 0, 1.2f);
        public static BasicItem boots = new BasicItem("ten league boots", 0, 0.1f);
        public static BasicItem breastplate = new BasicItem("breastplate of steel", 0, 1.4f);
        public static SimpleEnemy enemy = new SimpleEnemy(
                new SimpleArmor(5),
                List.of(new BasicBuff(1.0f, 1.0f))
        );
    }

    @Disabled("Test is not finished yet")
    @Test
    void damageCalculations() {
        Inventory inventory = new Inventory(null);
        Stats stats = new Stats(0);
        Player player = new Player(inventory, stats);

        Damage damage = player.calculateDamage(null);

        assertEquals(9, damage.getAmount());
    }
}
