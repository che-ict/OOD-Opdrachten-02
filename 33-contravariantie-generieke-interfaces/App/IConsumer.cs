namespace App;

public interface IConsumer<in T> { void Consume(T item); }
