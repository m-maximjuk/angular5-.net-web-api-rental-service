import { Injectable }    from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable()
export class MessageService {

    constructor(private toast: ToastrService) { }

    public Display(details: IMessageArgs): void {
    switch (details.option) {
        case MessageType.Error:
        this.toast.error(details.message, details.title, this.Options()); break;
        case MessageType.Success:
        this.toast.success(details.message, details.title, this.Options()); break;
        case MessageType.Warning:
        this.toast.warning(details.message, details.title, this.Options()); break;
        case MessageType.Info:
        this.toast.info(details.message, details.title, this.Options()); break;
        }
    }
    private Options() { return {closeButton: true, progressBar: true, positionClass: "toast-bottom-right"} }
}
export interface IMessageArgs {
    option?:  MessageType;
    title?:   string;
    message?: string;
}
export enum MessageType {
    Error,
    Success,
    Warning,
    Info
}