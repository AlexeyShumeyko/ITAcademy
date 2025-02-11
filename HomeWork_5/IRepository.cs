﻿public interface IRepository<T> where T : class
{
    void Add(T entity);

    T GetById(int id);

    void Update(T entity);

    void Delete(T entity);

    List<T> GetAll();
}