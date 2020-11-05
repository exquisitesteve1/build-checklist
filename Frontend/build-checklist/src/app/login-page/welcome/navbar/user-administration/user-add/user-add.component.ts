import { Component, EventEmitter, Input, OnInit, Output  } from '@angular/core';
import { UserView } from '../../../ViewModels/user-view-model';
import {FormGroup, FormControl, Validators} from '@angular/forms'
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-user-add',
  templateUrl: './user-add.component.html',
  styleUrls: ['./user-add.component.css']
})
export class UserAddComponent implements OnInit {

  userForm: FormGroup;
  editedUser: UserView;

  constructor(public activeModal: NgbActiveModal) { }

  ngOnInit(): void {

    this.userForm = new FormGroup({
      UserId: new FormControl(null, Validators.required),   
      Name: new FormControl(null, Validators.required),
      Email: new FormControl(null, Validators.required),
      Password: new FormControl(null, Validators.required),
      Lead: new FormControl(null, [Validators.required, Validators.maxLength(1)]),                         //////////
      Admin: new FormControl(null, [Validators.required, Validators.maxLength(1)]),
      Role: new FormControl(null, Validators.required),
    });

  }

  onSubmit(): void {

    this.editedUser = new UserView();
    this.editedUser.UserId = this.userForm.controls.UserId.value;
    this.editedUser.Name = this.userForm.controls.Name.value;
    this.editedUser.Email = this.userForm.controls.Email.value;
    this.editedUser.Password = this.userForm.controls.Password.value;
    this.editedUser.Lead = this.userForm.controls.Lead.value;
    this.editedUser.Admin = this.userForm.controls.Admin.value;
    this.editedUser.Role = this.userForm.controls.Role.value;
    console.log(this.editedUser.UserId);          /////
    console.log(this.editedUser.Name);
    console.log(this.editedUser.Email);
    console.log(this.editedUser.Password);
    console.log(this.editedUser.Lead);
    console.log(this.editedUser.Admin);
    console.log(this.editedUser.Role);
    this.onClose();
  }

  onClose(): void {
    this.activeModal.close(this.editedUser);
  }


}
