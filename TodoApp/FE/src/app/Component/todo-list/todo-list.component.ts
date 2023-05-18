import { Component, OnInit } from '@angular/core';
import { TodoService } from '../../Service/todo.service';
import { Todo } from '../../Models/Todo';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {
  todoList: Todo[] = [];
  constructor(private todoService: TodoService, private router: Router) { }
  taskSelect: number;
  ngOnInit(): void {
    this.getListToDo();
   
  }


  getListToDo() {
    this.todoService.getAllToDo().subscribe(data => {
      this.todoList = data;
    })
  }

  addTodoToList(todo: any) {
    this.todoService.addToDo(todo).subscribe(data => {
      this.getListToDo();
    }, (error) => {
      
    })
  }


  deleteToDo(id: number) {
    this.todoService.deleteTodo(id).subscribe(data => {
      this.getListToDo();
    }, (error) => {
     
    })
  }

  selectTask(todo: Todo) {
    this.taskSelect = todo.id;
  }

  moveTop() {
   
    this.todoService.moveTop(this.taskSelect).subscribe(res => {
      this.getListToDo();
      this.taskSelect = res.id
    }, (error) => {
      
    })
  }

  moveDown() {
   
    this.todoService.moveDown(this.taskSelect).subscribe(res => {
      this.getListToDo();
      this.taskSelect = res.id
    }, (error) => {
     
    })
  }

  redirectToDoDetail(id: number) {
    this.router.navigateByUrl('/todo/' + id);
  }
  checkSelect(id: number) {
    return this.taskSelect == id;
  }
}