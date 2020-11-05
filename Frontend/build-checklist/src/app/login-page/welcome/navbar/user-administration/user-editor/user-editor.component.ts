import { Component, EventEmitter, Input, OnInit, Output  } from '@angular/core';
import { UserView } from '../../../ViewModels/user-view-model';
import {FormGroup, FormControl, Validators} from '@angular/forms'
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-user-editor',
  templateUrl: './user-editor.component.html',
  styleUrls: ['./user-editor.component.css']
})
export class UserEditorComponent implements OnInit {

  @Input() user: UserView;
  userForm: FormGroup;
  editedUser: UserView;
  constructor(public activeModal: NgbActiveModal) { }

  ngOnInit(): void {
    this.userForm = new FormGroup({
      UserId: new FormControl(this.user.UserId, Validators.required),   //UserId (orignally was id)
      Name: new FormControl(this.user.Name, Validators.required),
      Email: new FormControl(this.user.Email, Validators.required),
      Password: new FormControl(this.user.Password, Validators.required),
      Lead: new FormControl('', Validators.required),                         //////////
      Admin: new FormControl(this.user.Admin, Validators.required),
      Role: new FormControl(this.user.Role, Validators.required),
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
