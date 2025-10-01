namespace App;

public interface IProducer<out T> { T Produce(); }
