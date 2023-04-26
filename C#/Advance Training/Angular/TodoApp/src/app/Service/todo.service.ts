import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http';
import { Todo } from '../Models/Todo';
@Injectable({
  providedIn: 'root'
})
export class TodoService {
  private readonly TODO_URL = 'http://localhost:5001/api/Todoes';
  constructor(private httpClient: HttpClient) { }

  public getAllToDo(): Observable<Todo[]> {
    return this.httpClient.get<Todo[]>(this.TODO_URL);
  }

  public addToDo(toDo: Todo): Observable<any> {
    return this.httpClient.post(this.TODO_URL, toDo);
  }

  
  public updateTodo(toDo: Todo): Observable<any> {
    return this.httpClient.put(this.TODO_URL, toDo);
  }

  public deleteTodo(id: number): Observable<any> {
    return this.httpClient.delete(this.TODO_URL+ '/' + id);
  }

  public findToDoById(id: number): Observable<Todo> {
    return this.httpClient.get<Todo>(this.TODO_URL+ '/' + id);
  }

}
