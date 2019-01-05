package esprit.tn.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.util.List;


/**
 * The persistent class for the Clientnotapproveds database table.
 * 
 */
@Entity
@Table(name="Clientnotapproveds")
@NamedQuery(name="Clientnotapproved.findAll", query="SELECT c FROM Clientnotapproved c")
public class Clientnotapproved implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="ClientId")
	private int clientId;

	private int client_Type;

	@Column(name="Email")
	private String email;

	@Column(name="IsApproved")
	private boolean isApproved;

	private String logo;

	@Column(name="NomClient")
	private String nomClient;

	@Column(name="Password")
	private String password;

	//bi-directional many-to-one association to Project
	@OneToMany(mappedBy="clientnotapproved")
	private List<Project> projects;

	public Clientnotapproved() {
	}

	public int getClientId() {
		return this.clientId;
	}

	public void setClientId(int clientId) {
		this.clientId = clientId;
	}

	public int getClient_Type() {
		return this.client_Type;
	}

	public void setClient_Type(int client_Type) {
		this.client_Type = client_Type;
	}

	public String getEmail() {
		return this.email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public boolean getIsApproved() {
		return this.isApproved;
	}

	public void setIsApproved(boolean isApproved) {
		this.isApproved = isApproved;
	}

	public String getLogo() {
		return this.logo;
	}

	public void setLogo(String logo) {
		this.logo = logo;
	}

	public String getNomClient() {
		return this.nomClient;
	}

	public void setNomClient(String nomClient) {
		this.nomClient = nomClient;
	}

	public String getPassword() {
		return this.password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public List<Project> getProjects() {
		return this.projects;
	}

	public void setProjects(List<Project> projects) {
		this.projects = projects;
	}

	public Project addProject(Project project) {
		getProjects().add(project);
		project.setClientnotapproved(this);

		return project;
	}

	public Project removeProject(Project project) {
		getProjects().remove(project);
		project.setClientnotapproved(null);

		return project;
	}

}