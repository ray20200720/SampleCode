class FreshJuice {
    enum FreshJuiceSize { SMALL, MEDIUM, LARGE }
    FreshJuiceSize size;
}

public class FreshJuiceTest {
    public static void main(String[] args) {
        FreshJuice juice = new FreshJuice();
        juice.size = FreshJuice.FreshJuiceSize.SMALL;
        System.out.println(juice.size);
        Dog dog = new Dog();
        dog.age = 12;
        dog.colour = "brown";
        System.out.println(dog.age);
    }
}