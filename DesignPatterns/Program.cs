﻿/// <summary>
/// author zhenhaiwang
/// email 601748025@qq.com
/// </summary>

using System;

//using SimpleFactory;
//using FactoryMethod;
//using AbstractFactory;
//using SingletonPattern;
//using ObserverPattern;
//using StrategyPattern;
//using StatePattern;
//using DecoratorPattern;
//using CommandPattern;
//using TemplateMethod;
//using AdapterPattern;
//using FacadePattern;
//using IteratorPattern;
//using CompositePattern;
//using ProxyPattern;
//using BridgePattern;
//using PrototypePattern;
//using MementoPattern;
//using BuilderPattern;
//using ChainOfResponsibility;
//using InterpreterPattern;
//using VisitorPattern;
//using MediatorPattern;
using FlyweightPattern;

namespace DesignPatterns
{
    /// ******** ///
    /// 变化 解耦 ///
    /// 扩展 艺术 ///
    /// ******** ///

    class Program
    {
        static void Main(string[] args)
        {
            //1.SimpleFactory
            //Animal animal = Factory.CreatAnimal("Cat");
            //animal.PrintName();

            //2.FactoryMethod
            //CatFactory cf = new CatFactory();
            //Animal animal = cf.CreatAnimal("");
            //animal.PrintName();

            //3.AbstractFactory
            //BlueCatFactory bcf = new BlueCatFactory();
            //LittleCat cat = bcf.CreatLittleCat("");
            //cat.PrintName();

            //4.SingletonPattern
            //Singleton.instance.Print();

            //5.ObserverPattern
            //ConcreteSubject subject = new ConcreteSubject();
            //ConcreteObserver observer = new ConcreteObserver(subject);
            //subject.SetData("Data is changed!");
            //observer.Destroy();

            //6.StrategyPattern
            //Addition addition = new Addition();
            ////Multiplication multiplication = new Multiplication();
            //Calculator calculator = new Calculator(addition);
            //Console.WriteLine(calculator.Compute(10, 5).ToString());

            //7.StatePattern
            //PlayerController controller = new PlayerController(7);
            //while (true)
            //{
            //    ConsoleKeyInfo input = Console.ReadKey();
            //    switch (input.KeyChar)
            //    {
            //        case 'A':
            //            controller.PressA();
            //            break;
            //        case 'B':
            //            controller.PressB();
            //            break;
            //        case 'C':
            //            controller.PressC();
            //            break;
            //        case 'Q':
            //            return;
            //    }
            //}

            //8.DecoratorPattern
            //Component blackCoffee = new BlackCoffee();
            //blackCoffee =
            //    new Sugar(                              //4.再加糖
            //        new Milk(                           //3.再加牛奶
            //            new Sugar(                      //2.加糖
            //                new Milk(blackCoffee))));   //1.加牛奶
            //blackCoffee.Print();

            //9.CommandPattern
            //RemoteController controller = new RemoteController();
            //Light light = new Light();
            //TV tv = new TV();
            //LightOnCommand lightOn = new LightOnCommand(light);
            //LightOffCommand lightOff = new LightOffCommand(light);
            //controller.SetCommand(lightOn, lightOff);
            //controller.ClickOn();
            //controller.ClickOff();
            //TVOnCommand tvOn = new TVOnCommand(tv);
            //TVOffCommand tvOff = new TVOffCommand(tv);
            //controller.SetCommand(tvOn, tvOff);
            //controller.ClickOn();
            //controller.ClickOff();

            //10.TemplateMethod
            //ConcreteMethod1 method1 = new ConcreteMethod1();
            //Console.WriteLine("Execute method1");
            //method1.Execute();
            //ConcreteMethod2 method2 = new ConcreteMethod2();
            //Console.WriteLine("\nExecute method2");
            //method2.Execute();

            //11.AdapterPattern
            //ConcreteEnumeration enumeration = new ConcreteEnumeration();
            //ConcreteIteration iteration = new ConcreteIteration();
            //Iteration adapter = new Adapter(enumeration);
            //adapter.HasNext();
            //adapter.Next();
            //adapter.Remove(null);   //此处抛出异常

            //12.FacadePattern
            //SubSystem1 sys1 = new SubSystem1();
            //SubSystem2 sys2 = new SubSystem2();
            //SubSystem3 sys3 = new SubSystem3();
            //Facade facade = new Facade(sys1, sys2, sys3);
            //facade.Execute();

            //13.IteratorPattern
            //NameData name = new NameData();
            //ColorData color = new ColorData();
            //Iterator nameIterator = name.CreateIterator();
            //while (nameIterator.HasNext())
            //    Console.WriteLine((string)nameIterator.Next());
            //Iterator colorIterator = color.CreateIterator();
            //while (colorIterator.HasNext())
            //    Console.WriteLine((string)colorIterator.Next());

            //14.CompositePattern
            //MenuComponent rootMenu = new Menu("文件");
            //MenuComponent openMenu = new Menu("打开");
            //MenuComponent projectItem = new MenuItem("项目/解决方案");
            //MenuComponent closeItem = new MenuItem("关闭");
            //MenuComponent quitItem = new MenuItem("退出");
            //rootMenu.Add(closeItem);
            //rootMenu.Add(quitItem);
            //rootMenu.Add(openMenu);
            //openMenu.Add(projectItem);
            //rootMenu.Print();

            //15.ProxyPattern
            //Proxy proxy = Proxy.RegisterProxy("http://...");
            //if(proxy != null)
            //    proxy.Request();

            //16.BridgePattern
            //CalculatorAbstraction calculator = new Calculator();
            //calculator.strategy = new Addition();
            //Console.WriteLine(calculator.Compute(10, 5).ToString());
            //calculator.strategy = new Multiplication();
            //Console.WriteLine(calculator.Compute(10, 5).ToString());

            //17.PrototypePattern
            //ConcretePrototype prototype = new ConcretePrototype();
            //ConcretePrototype deepClone = prototype.Clone(true) as ConcretePrototype;       //深克隆
            //Console.WriteLine(prototype == deepClone);
            //Console.WriteLine(prototype.member == deepClone.member);
            //ConcretePrototype shallowClone = prototype.Clone(false) as ConcretePrototype;   //浅克隆
            //Console.WriteLine(prototype == shallowClone);
            //Console.WriteLine(prototype.member == shallowClone.member);

            //18.MementoPattern
            //System.Collections.Generic.List<ContactPerson> persons = new System.Collections.Generic.List<ContactPerson>()
            //{
            //    new ContactPerson() { name=  "张三", number = "000000000"},
            //    new ContactPerson() { name = "李四", number = "111111111"},
            //    new ContactPerson() { name = "王五", number = "222222222"}
            //};
            //Originator admin = new Originator(persons);
            //admin.Print();
            //Caretaker caretaker = new Caretaker();
            //string time = DateTime.Now.Ticks.ToString();
            //caretaker.contactMementoDic.Add(time, admin.CreateMemento());   //创建还原点
            //admin.contactPersonList.RemoveAt(0);
            //admin.Print();
            //admin.RestoreMemento(caretaker.contactMementoDic[time]);        //还原到前一个联系人状态
            //admin.Print();

            //19.BuilderPattern
            //Director director = new Director();
            //Builder b1 = new ConcreteBuilder1();
            //Builder b2 = new ConcreteBuilder2();
            //director.Construct(b1);
            //Product p1 = b1.GetFinalProduct();
            //p1.Print();
            //director.Construct(b2);
            //Product p2 = b2.GetFinalProduct();
            //p2.Print();

            //20.ChainOfResponsibility
            //ConcreteHandler1 handler1 = new ConcreteHandler1();
            //ConcreteHandler2 handler2 = new ConcreteHandler2();
            //ConcreteHandler3 handler3 = new ConcreteHandler3();
            //handler1.next = handler2;
            //handler2.next = handler3;
            //string[] requests = { "Handler2", "Handler3", "Handler1", "Handler3" };
            //foreach (string request in requests)
            //{
            //    handler1.HandleRequest(request);
            //}

            //21.InterpreterPattern
            //string english = "This is an apple.";
            //string chinese = Translator.TranslateToChinese(english);
            //Console.WriteLine(chinese);

            //22.VisitorPattern
            //ElementList elementList = new ElementList();
            //foreach (Element e in elementList.elements)
            //{
            //    e.Accept(new ConcreteVistor1());
            //    e.Accept(new ConcreteVistor2());
            //}

            //23.MediatorPattern
            //PlayerA a = new PlayerA("Player A");
            //PlayerB b = new PlayerB("Player B");
            //Mediator mediator = new Mediator(a, b);
            //mediator.ATalk();
            //mediator.BTalk();

            //24.FlyweightPattern
            FlyweightFactory factory = new FlyweightFactory();
            FlyweightTree poplarTree = factory.GetTree("Poplar");
            Console.WriteLine(poplarTree.ToString());
            poplarTree.height = 5.5f;
            poplarTree.orientation = 90.0f;
            Console.WriteLine(poplarTree.ToString());
            FlyweightTree willowTree = factory.GetTree("Willow");
            willowTree.height = 4.5f;
            willowTree.orientation = 125.0f;
            Console.WriteLine(willowTree.ToString());
            willowTree.height = 2.5f;
            willowTree.orientation = 45.0f;
            Console.WriteLine(willowTree.ToString());

            Console.Read();
        }
    }
}
