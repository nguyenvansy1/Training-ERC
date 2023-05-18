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
      console.log(error)
    })
  }

  // addTodo(addForm: FormGroup) {
  //   this.todoService.addToDo(addForm.value).subscribe(data => {
  //     this.getListToDo();
  //   }, (error) => {
  //     console.log(error)
  //   })
  // }

  deleteToDo(id: number) {
    this.todoService.deleteTodo(id).subscribe(data => {
      this.getListToDo();
    }, (error) => {
      console.log(error)
    })
  }

  selectTask(todo: Todo) {
    this.taskSelect = todo.id;
  }

  moveTop() {
    console.log(this.taskSelect)
    this.todoService.moveTop(this.taskSelect).subscribe(res => {
      this.getListToDo();
      this.taskSelect = res.id
    }, (error) => {
      console.log(error)
    })
  }

  moveDown() {
    console.log(this.taskSelect)
    this.todoService.moveDown(this.taskSelect).subscribe(res => {
      this.getListToDo();
      this.taskSelect = res.id
    }, (error) => {
      console.log(error)
    })
  }

  redirectToDoDetail(id: number) {
    this.router.navigateByUrl('/todo/' + id);
  }
  checkSelect(id: number) {
    return this.taskSelect == id;
  }
}
