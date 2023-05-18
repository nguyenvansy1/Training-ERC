import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Todo } from 'src/app/Models/Todo';
import { TodoService } from 'src/app/Service/todo.service';


@Component({
  selector: 'app-todo-detail',
  templateUrl: './todo-detail.component.html',
  styleUrls: ['./todo-detail.component.css']
})
export class TodoDetailComponent implements OnInit {
  toDoId: number;
  toDo: Todo;
  constructor(private activatedRoute: ActivatedRoute, private toDoService : TodoService) { }

  ngOnInit(): void {
    this.getToDoById();
  }


  getToDoById(){
    this.toDoId = parseInt(this.activatedRoute.snapshot.params['id']);
    this.toDoService.findToDoById(this.toDoId).subscribe(data => {
      this.toDo = data;
     
    })
  }
}
