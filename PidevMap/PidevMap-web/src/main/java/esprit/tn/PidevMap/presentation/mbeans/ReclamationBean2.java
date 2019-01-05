package esprit.tn.PidevMap.presentation.mbeans;

import java.util.List;

import javax.ejb.EJB;
import javax.faces.application.FacesMessage;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.ManagedProperty;
import javax.faces.bean.SessionScoped;
import javax.faces.context.FacesContext;

import esprit.tn.entities.AspNetUser;
import esprit.tn.entities.Reclamation;
import esprit.tn.services.ReclamationService;

@ManagedBean
@SessionScoped
public class ReclamationBean2 {

	private int reclamationId;
	private String message_content;
	private String message_object;
	private AspNetUser aspNetUser;
	private List<Reclamation> reclamations;

	@EJB
	ReclamationService reclamationService;

	public void addReclamation() {
		reclamationService.ajouterReclamation(new Reclamation(message_content, message_object));
	}

	public void modifier(Reclamation Reclamation) {
		this.setMessage_content(Reclamation.getMessage_content());
		this.setMessage_object(Reclamation.getMessage_object());
		this.setReclamationId(Reclamation.getReclamationId());
	}

	public void mettreAjourReclamation() {
		reclamationService.updaterec(new Reclamation(reclamationId, message_content, message_object));
	}

	public void supprimer(int ReclamationId) {
		reclamationService.DeleteReclamationById(ReclamationId);
	}

	public List<Reclamation> getListReclamation() {

		reclamations = reclamationService.findAll();
		return reclamations;
	}

	public String redirectList() {
		String navigateTo = "null";
		navigateTo = "/pages/admin/Reclamationes?faces-redirect=true";
		return navigateTo;

	}
	

	public int getReclamationId() {
		return reclamationId;
	}

	public void setReclamationId(int reclamationId) {
		this.reclamationId = reclamationId;
	}

	public String getMessage_content() {
		return message_content;
	}

	public void setMessage_content(String message_content) {
		this.message_content = message_content;
	}

	public String getMessage_object() {
		return message_object;
	}

	public void setMessage_object(String message_object) {
		this.message_object = message_object;
	}

	public AspNetUser getAspNetUser() {
		return aspNetUser;
	}

	public void setAspNetUser(AspNetUser aspNetUser) {
		this.aspNetUser = aspNetUser;
	}

	public ReclamationService getReclamationService() {
		return reclamationService;
	}

	public void setReclamationService(ReclamationService reclamationService) {
		this.reclamationService = reclamationService;
	}

	public List<Reclamation> getReclamations() {
		return reclamations;
	}

	public void setReclamations(List<Reclamation> reclamations) {
		this.reclamations = reclamations;
	}

}
