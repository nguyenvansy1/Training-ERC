import { Component, OnInit } from '@angular/core';
import { TodoService } from '../Service/todo.service';
import { Todo } from '../Models/Todo';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {
  todoList: Todo[] = [];
  constructor(private todoService: TodoService,  private fb: FormBuilder, private router: Router) { }
  formCreate: FormGroup;
  taskSelect: Todo ;
  ngOnInit(): void {
    this.getListToDo();
    this.formCreate = this.fb.group(
      {
        name: ['', Validators.required],
        description: ['', Validators.required],
      }
    );
  }
  

  getListToDo() {
     this.todoService.getAllToDo().subscribe(data => {
      this.todoList = data;
      console.log(data)
     })
  }
   

  addTodo(addForm: FormGroup) {
     this.todoService.addToDo(addForm.value).subscribe(data => {
        this.getListToDo();
     }, (error) => {
      console.log(error)
     })
  }

  deleteToDo(id: number) {
    this.todoService.deleteTodo(id).subscribe(data => {
      this.getListToDo();
    }, (error) => {
      console.log(error)
     })
  }

  selectTask(todo: Todo) {
      this.taskSelect = todo;
  }

  moveTop() {
    const index = this.todoList.findIndex(item => item === this.taskSelect);
    if (index !== -1) {
      this.todoList.splice(index, 1);
      this.todoList.unshift(this.taskSelect);
    }
  }

  moveDown() {
    const index = this.todoList.findIndex(item => item === this.taskSelect);
    if (index !== -1 && index !== this.todoList.length - 1) {
      this.todoList.splice(index, 1);
      this.todoList.push(this.taskSelect);
    }
  }

  redirectToDoDetail(id: number) {
    console.log("1")
    this.router.navigateByUrl('/todo/' + id);
  }
}
