import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-todo-add',
  templateUrl: './todo-add.component.html',
  styleUrls: ['./todo-add.component.css']
})
export class TodoAddComponent implements OnInit {
  formCreate: FormGroup;
  @Output() newTodo = new EventEmitter<string>();
  constructor( private fb: FormBuilder,) { }

  ngOnInit(): void {
    this.formCreate = this.fb.group(
      {
        name: ['', Validators.required],
        description: ['', Validators.required],
      }
    );
  }
  addTodo(addForm: FormGroup) {
     const value = addForm.value;
     this.newTodo.emit(value);
  }
}