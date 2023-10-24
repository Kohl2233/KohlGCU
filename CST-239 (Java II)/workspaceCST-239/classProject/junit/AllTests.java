package junit;

import org.junit.runner.RunWith;
import org.junit.runners.Suite;
import org.junit.runners.Suite.SuiteClasses;

@RunWith(Suite.class)
@SuiteClasses({ ArmorTest.class, HealthTest.class, InventoryManagerTest.class, SalableProductTest.class,
		WeaponTest.class })
public class AllTests {

}
